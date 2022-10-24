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

namespace Area_Yapilanmasi
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areaDefault", // arealar i�in default rota tan�mlad�k. Area varsa hangi areaysa i�indeki home index tetiklenecek
                                         // a�a��daki rotada area ismini controllerlara verdi�imiz area attribute'undaki isimden alacak
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "yonetim",
                    areaName: "yonetim_paneli", // yukar�daki area:exist olan parametrenin kar��l��� bu.
                                                // bu sayede belirli bir areaya �zel rota tan�mlayabiliyoruz
                    pattern: "admin/{controller=home}/{action=Index}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(   // arealar aras� nas�l ba�lant� kuruldu�u i�in --> yonetim_paneli/Views/Home/Index
                   name: "fatura",
                   areaName: "fatura_paneli", 
                   pattern: "fatura/{controller=home}/{action=Index}/{id?}"
                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
