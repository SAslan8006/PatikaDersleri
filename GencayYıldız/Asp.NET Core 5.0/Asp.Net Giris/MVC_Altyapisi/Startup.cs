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
            /* Uygulamada kullanýlacak servisler buraya eklenir. Servis belirli iþlere odaklanmýþ ve o iþin sorumluluðunu üstlenmiþ kütüphaneler sýnýflar vb þeylerdir. 
             * Örneðin yapacaðýmýz web uygulamasýnda bir ödeme sistemi olacak 
             bununla ilgili bulduðumuz paket bir servistir. Bunu dahil edebilmek için burada çaðýrmamýz gerekir. Burada mesela razorpages kullanýlmýþ*/
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

            app.UseRouting(); // Gelen isteðin rotasý bu middleware sayesinde belirlenir.

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>  // endpoint yapýlan isteðin varýþ noktasýdýr.
            {
               endpoints.MapDefaultControllerRoute();

                // istek yapýlacak varsayýlan rotayý belirler
                /* Endpoint tanýmlamasýnda süslü parantezler içinde parametreler tanýmlanabilir. 
                 * Controller ve Action parametreleri ise öntanýmlýdýr */
            });
        }
    }
}
