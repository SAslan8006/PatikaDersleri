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

namespace Kullanıcıdan_Veri_Alma_Yontemleri
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
            services.AddRazorPages();
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute(); // bu default olarak sadece id'yi controllera gönderir. Birden fazla route yapılanması kullanılabilir
                endpoints.MapControllerRoute("RouteExample", "{controller=Home}/{action=Index}/{a}/{b}/{id}");
                // ilk parametre rota adı sonraki parametre de rota
                // rotadan gelen parametreler de aynı diğer yöntemlerdeki gibi karşılanabilir. Model üzerinden, parametre üzerinden veya request üzerinden.
                /* querystring ve route yapılanmaları arasındaki fark route yapılanmasının daha güvenli olması.
                 * querystringde hangi girdinin hangi parametre adıyla geçtiğini vs görebilirken
                 * route yapılanmasında sadece giden değerler görünür */
            });
        }
    }
}
