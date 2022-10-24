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

namespace MVC_Altyapisi
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
            /* Uygulamada kullan�lacak servisler buraya eklenir. Servis belirli i�lere odaklanm�� ve o i�in sorumlulu�unu �stlenmi� k�t�phaneler s�n�flar vb �eylerdir. 
             * �rne�in yapaca��m�z web uygulamas�nda bir �deme sistemi olacak 
             bununla ilgili buldu�umuz paket bir servistir. Bunu dahil edebilmek i�in burada �a��rmam�z gerekir. Burada mesela razorpages kullan�lm��*/
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting(); // Gelen iste�in rotas� bu middleware sayesinde belirlenir.

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>  // endpoint yap�lan iste�in var�� noktas�d�r.
            {
               endpoints.MapDefaultControllerRoute();

                // istek yap�lacak varsay�lan rotay� belirler
                /* Endpoint tan�mlamas�nda s�sl� parantezler i�inde parametreler tan�mlanabilir. 
                 * Controller ve Action parametreleri ise �ntan�ml�d�r */
            });
        }
    }
}
