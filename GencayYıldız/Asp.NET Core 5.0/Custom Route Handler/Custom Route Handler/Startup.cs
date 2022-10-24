using Custom_Route_Handler.Handlers;
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

namespace Custom_Route_Handler
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
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
            app.UseStaticFiles(); //resimleri çağırmak için gerekli midillawaredir olmazsa olmazdır. 

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.Map("example-route", async c =>
                //{
                //    // https://localhost:5001/example-route endpointine gelen herhangi bir istek controller taraf�ndan de�il direk burada belirtti�imiz metot taraf�ndan kar��lan�r.
                //    // Controller tetiklenmeyece�i i�in maliyetten tasarruf edilir.
                //});
                endpoints.Map("example-route", new ExampleHandler().Handler());
                // Geri d�n�� i�in bir class olu�turduk. Example-route patterninde bir istek geldi�inde ExampleHandler class�n�n handler metodu tetiklenecek

                endpoints.Map("image/{imageName}", new ImageHandler().Handler(env.WebRootPath)); // env.webrootpath ile wwwroot klas�r�m�z�n yolunu yollad�k.


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
