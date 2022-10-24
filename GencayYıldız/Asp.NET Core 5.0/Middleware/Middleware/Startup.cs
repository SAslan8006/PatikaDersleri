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

namespace Middleware
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
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // T�m middleware'ler burada, configure metodunun i�inde �a�r�l�r. .Net mimarisinde t�m middleware'ler use ad�yla ba�lar.
            // Middlewareler i� i�e sarmal yap�da bulunur yani biri �al���p sonlanmadan bir di�eri �a�r�l�r. Dolay�s�yla tetiklenme s�ras� �nemlidir.
            // �rne�in UseRouting UseEndpointsten �nce gelmelidir. �nce rota e�le�meli ki hangi controllerin tetiklenece�ini bilelim.
            // Authentication de authorizationdan �nce tetiklenmelidir. �nce kimlik do�rulan�r sonra yetkilendirme yap�l�r.

            // 4 tane temel haz�r middleware vard�r
            /* Run --> Tetiklendi�i zaman kendinden sonra gelen middleware'leri tetiklemez akış sonlanı r. Bu �zellike short circuit (k�sa devre) denir.
             * Use
             * Map
             * MapWhen
             * 
             * *** Use metodu ***
             * use kulland���m�zda s�radaki middleware'i �a��r�p ve �a�r�lan middleware i�lemi bitirdikten sonra
             * geriye d�n�p devam eden bir yap� olu�ur.
             * Task bir sonraki �al��t�r�lacak middleware'i temsil eder. task.Invoke() ile o metot �al��t�r�l�r.
             * app.Use(async (context, task) =>
             * {
             *      Console.WriteLine("Start use middleware");
             *      await task.Invoke();
             *      Console.WriteLine("Stop use middleware")
             * });
             * app.Run(async c =>
             * {
             *      Console.WriteLine("Start Run middleware");
             * });
             * Bu kod blo�unun konsolda ��kt�s�;
             * Start use middleware
             * Start run middleware
             * Stop use middleware 
             * olacakt�r.
             * 
             * *** Map metodu ***
             * Gelen talebin pathine g�re farkl� middlewareler �al��t�rmam�z� sa�lar
             * 
             * app.Map("/weatherforecast", builder =>
             * {
             *      builder.Run(async c => c.Response.WriteAsync("Run tetiklendi"));
             * });
             * 
             * *** MapWhen metodu ***
             * Mapte sadece requestin yap�ld��� pathe g�re filtreleme yap�l�rken, MapWhen ile requestin herhangi bir �zelli�ine g�re filtreleme yap�labilir.
             * 
             * app.MapWhen(c => c.Request.Method == "GET", builder =>
             * {
             *      builder.Use(async (context, task) =>
             *      {
             *          Console.WriteLine("start use middleware");
             *          await task.Invoke();
             *          Console WriteLine("stop use middleware");
             *      });
             * });
             * 
             * kendi middlewareimizi olu�turduk --> Middlewares klas�r�n�n i�inde
             */

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
               
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
