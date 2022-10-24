using Microsoft.AspNetCore.Mvc;

namespace Layout_Yapilanmasi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ***** RenderBody ve RenderSection *****
            /* _layoutun mantığını zaten biliyorsun genel olarak anlatmıyıcam. 
             * @RenderBody() --> Viewdeki görüntünün layoutta yerleştirileceği kısımdır.
             * @RenderSection("bolumIsmi", required: false) --> View üzerinden section açarak ek değişiklikler yapabileceğimiz kısım
             * mesela bazı viewlerde javascript kullanıyosun. Layoutta scriptler diye bi rendersection ekleyerek
             * viewlerde scriptler sectionu açıp kullanacağın scriptleri ekleyebilirsin. Bu sayede sadece ihtiyacın olan sayfalarda
             * scriptleri dahil edip tüm sayfalarda gereksiz yere dahil etmemiş olursun.
             */

            // ***** _ViewStart.cshtml *****
            /* Tüm viewlerde yapılması gereken ortak yapılandırmalar için kullanılır. Örneğin layout tanımlaması tüm viewler için yapılmalıdır
             * Viewstart dosyasında bunu yapabiliriz. Önce viewstart render edilir sonra view render edilir. 
             */

            // ***** _ViewImports.cshtml *****
            /* Razor sayfalarında kütüphane ve namespace tanımlamalarını tek tek yapmaktansa merkezi olarak tanımlamamızı sağlar.
             */

            // ***** PartialView ve ViewComponent *****
            /* Partialviewler dataları controllerdan alır. Ana içerikle alakasız çok fazla parça kullanılacağı durumlarda (mesela reklam içerikleri vs) 
             * controllerdan 50 tane veri alıp onu boğmak yerine viewcomponent kullanılır
             * Componentın kendi bir cs dosyası bulunur o dosya üzerinden reklamlar vb içerikler çekilir. Render süreci bakımından component daha iyi
             * bir performans sergiler.
             * PartilaView kullanımı için --> Index.cshtml
             * 
             * ViewComponent kullanılırken cs dosyasını oluşturduk. Sonra hangi contollerın viewinde kullanılacaksa o dizinde components klasörü oluşturup içinde componentimizle aynı isimde bir klasör ekledik. İsimlendirme önemli çünkü viewi ararken isimlendirmeye göre dizinlere bakıyor. 
             * Yani örneğin home sayfasında kullandıkya çağrıldığında gidiyor Views(veya Shared)/Home/Components/Personeller dizininde viewini arıyor.
             * Herhangi bir view ismi belirtilmediyse defaultu bulup döner. Bu yöntem controller bazlı componentler kullanılacağı zaman uygulanır.
             * Biraz fazla uğraştırıcı sürekli klasör açıyosun vs.
             * Uygulamanın bütününde kullanılacaksa shared klasörünün altında component klasörü açıp onun da altında personeller klasörü açıyosun.
             * Yani öbürü uğraştırıcı da bu da aynı aslında. İhtiyaca göre uygulama bazlı veya controller bazlı kullanırsın.
             * ViewComponentin nasıl çağrıldığı --> Index.cshtml
             */

            
          
            return View();
        }
    }
}
