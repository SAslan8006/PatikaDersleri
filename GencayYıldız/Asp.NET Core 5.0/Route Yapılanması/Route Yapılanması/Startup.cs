using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Route_Yapılanması.Constraints.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Route_Yapılanması
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
            services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint)));
            // Yukardaki satırı ekleyerek constraintimizi dahil ettik?
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("rotaAdi","{controller=Personel}/{action=Index}");
                // Kendin rota oluşturmak istiyorsan bunu kullanacaksın. Her bir route'un bir ismi olması gerekiyor.
                // eşittirle verdiğin değerler herhangi bir şey gelmediğinde default olarak ne yapacağı.

                endpoints.MapDefaultControllerRoute(); // bunun ismi ön tanımlı olarak defaulttur

                endpoints.MapControllerRoute("rotam", "anasayfa", new { controller = "Home", action = "Index" });
                // bu kullanımda anasayfa adında statik bir url verdik. 3.parametrede de bu statik değerin tetikleyeceği yeri verdik.
                // farklı farklı rotalar tanımlayacaksak özelden genele doğru tanımlanmalı ki önce özeller kontrol edilsin
                // özellere uymayan en alta inip defaultu çalıştırsın
                // yukarda direk defaultu verirsek aşağıda yazdığımız özellerin pek bi olayı kalmaz. Buradaki sıralama önemli.
                // şu an not aldığım için sıralamayı düzgün yapmadım.
                // ** Şöyle bir olay var şimdi burada home/indexi anasayfa olarak tanımladıkya sayfada kullandığımız bütün home-index linkleride
                // bir linkin üzerine geldiğinde yönlendirdiği url yazıyorya anasayfa yazacak orada.
                endpoints.MapControllerRoute("rota3", "{controller=Home}/{action=Index}/{id}/{x?}/{y?}");
                /* nullable bir parametre kullanacaksak en sondan başlamalıdır. Çünkü ortada bir nullable parametre olursa 
                 * sıra karışır parametreleri düzgün yakalayamaz. */
                endpoints.MapControllerRoute("rota3", "{controller=Home}/{action=Index}/{id:int?}/{x:length(12)}/{y:alpha:length(10)}/{z:custom}");
                // parametreye iki nokta ile tür verip türünü kısıtlayabiliyoruz.              
                /* kullanılabilecek türler;
                 * int
                 * alpha --> büyük veya küçük sadece ingilizce karakterler
                 * bool
                 * datetime
                 * decimal
                 * double
                 * float
                 * guid
                 */
                // kaç karakter olması gerektiğini vs de belirtebiliyoruz
                /* kullanılabilecek şeyler;
                 * length(value)
                 * maxlength(value)
                 * minlength(value)
                 * range(min,max)
                 * min(value)
                 * max(value)
                 */

                // Kendimiz de bir constraint classı oluşturup ayarlamalar yaparak burada rota parametrelerine verebiliyoruz (z parametresine verdik) .
                // -- Constraint klasörünün içinde class oluşturduk ona git.

                /**** Attribute kullanarak routing ****/
                // Önce gittik controllerımıza bir route attribute vererek rotasını belirttik. Sonra da buraya gelip alttaki MapControllers'i ekledik
                endpoints.MapControllers(); // Controllerdan gelen isteği controllerdaki rotalarla eşleştir

            });
        }
    }
}
