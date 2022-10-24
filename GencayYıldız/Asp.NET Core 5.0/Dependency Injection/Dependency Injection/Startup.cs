using Dependency_Injection.Services;
using Dependency_Injection.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

       
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog())); // add ile bir �ey ekledi�imizde default olarak singleton olarak ekler.
            services.AddSingleton<ConsoleLog>(); // ConsoleLog t�r�nden bir nesne al�p istek geldi�inde onu g�nderecek
            services.AddSingleton<TextLog>(p => new TextLog(5)); // constructorunda parametre alan �eyler i�in ise bu �ekilde parametresini veriyoruz. Yani bu nesneden 5 parametresiyle �rnek olu�tur dedik.
            services.AddScoped<ConsoleLog>(); // yine ayn� bu �ekilde scoped veya transient olarak da ekleyebiliyoruz

            services.AddScoped<ILog>(p => new TextLog(5)); // Bir yerde ILog iste�i yap�ld���nda buradaki verdi�imiz TextLog d�necek. E�er ileride ihtiya� de�i�ir ve ConsoleLog kullanmak istersek de 
                                                           // uygulamada yapaca��m�z tek i� buradaki TextLogu ConsoleLog ile de�i�tirmek olacak
            services.AddScoped<ILog, ConsoleLog>(); // Bu �ekilde de kullan�m var. Kritik nokta genericteki 1.parametre interface 2. parametre ise o interfaceden kal�t�lm�� bir s�n�f olmal�.
                                                    // ayr�ca ctoru parametre alm�yor olmal� ki b�yle kullanabilelim.

            // --> HomeControllera ge�

            services.AddControllersWithViews();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
