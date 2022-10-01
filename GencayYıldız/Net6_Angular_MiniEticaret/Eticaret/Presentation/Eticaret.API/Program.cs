using ETicaret.API.Extensions;
using ETicaret.Application;
using ETicaret.Application.Validatiors.Products;
using ETicaret.Infrastructure;
using ETicaret.Infrastructure.Filters;
using ETicaret.Infrastructure.Services.Storage.Azure;
using ETicaret.Infrastructure.Services.Storage.Local;
using ETicaret.Persistence;
using ETicaretAPI.API.Configurations.ColumnWriters;
using ETicaretSignalR;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.IdentityModel.Tokens;
using NpgsqlTypes;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;
using System.Security.Claims;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHttpContextAccessor();//Client'tan gelen request neticvesinde oluþturulan HttpContext nesnesine katmanlardaki class'lar üzerinden(busineess logic) eriþebilmemizi saðlayan bir servistir.
        builder.Services.AddPersistenceServices();
        builder.Services.AddInfrastructureServices();
        builder.Services.AddApplicationServices();
        builder.Services.AddSignalRServices();

        //builder.Services.AddStorage<LocalStorage>();
        builder.Services.AddStorage<AzureStorage>();
        //builder.Services.AddStorage();

        builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
            policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials()
        ));

        Logger log = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt")
            .WriteTo.PostgreSQL(builder.Configuration.GetConnectionString("PostgreSQL"), "logs",
                needAutoCreateTable: true,
                columnOptions: new Dictionary<string, ColumnWriterBase>
                {
            {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
            {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
            {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
            {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
            {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
            {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
            {"user_name", new UsernameColumnWriter()}
                })
            .WriteTo.Seq(builder.Configuration["Seq:ServerUrl"])
            .Enrich.FromLogContext() 
            .MinimumLevel.Information()
            .CreateLogger();

        builder.Host.UseSerilog(log);

        builder.Services.AddHttpLogging(logging =>
        {
            logging.LoggingFields = HttpLoggingFields.All;
            logging.RequestHeaders.Add("sec-ch-ua");
            logging.MediaTypeOptions.AddText("application/javascript");
            logging.RequestBodyLogLimit = 4096;
            logging.ResponseBodyLogLimit = 4096;
        });

        builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
            .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>())
            .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer("Admin", options =>
            {
                options.TokenValidationParameters = new()
                {
                    ValidateAudience = true, //Oluþturulacak token deðerini kimlerin/hangi originlerin/sitelerin kullanýcý belirlediðimiz deðerdir. -> www.bilmemne.com
                    ValidateIssuer = true, //Oluþturulacak token deðerini kimin daðýttýný ifade edeceðimiz alandýr. -> www.myapi.com
                    ValidateLifetime = true, //Oluþturulan token deðerinin süresini kontrol edecek olan doðrulamadýr.
                    ValidateIssuerSigningKey = true, //Üretilecek token deðerinin uygulamamýza ait bir deðer olduðunu ifade eden suciry key verisinin doðrulanmasýdýr.

                    ValidAudience = builder.Configuration["Token:Audience"],
                    ValidIssuer = builder.Configuration["Token:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
                    LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,

                    NameClaimType = ClaimTypes.Name //JWT üzerinde Name claimine karşılık gelen değeri User.Identity.Name propertysinden elde edebiliriz.
                };
            });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.ConfigureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());
        app.UseStaticFiles();

        app.UseSerilogRequestLogging();

        app.UseHttpLogging();
        app.UseCors();
        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();
        app.Use(async (context, next) =>
        {
            var username = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;
            LogContext.PushProperty("user_name", username);
            await next();
        });

        app.MapControllers();
        app.MapHubs();

        app.Run();
    }
}