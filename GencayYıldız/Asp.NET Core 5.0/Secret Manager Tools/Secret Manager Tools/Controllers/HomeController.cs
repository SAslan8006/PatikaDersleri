using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Secret_Manager_Tools.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Secret_Manager_Tools.Controllers
{
    public class HomeController : Controller
    {

        // bir asp.net uygulamasını yayınladığımızda içinde appsettings.json da bulunur
        // bu da gizliliği ihlal eder. Appsettingste connection string vs gibi önemli bilgileri tutmamalıyız

        // **** bir proje nasıl publish edilir? ****
        // projeye sağ tık --> publish
        // publishten sonra servera gidecek dosyaları verir sana. VS'de bu dosyaları görebilmek için
        // solution explorerde show all files seçeneği var ona tıkla. bin/debug/release/net5.0/publish 
        // içindeki dosyaları servera gönderiyosun
        // appsettings dosyası da servera gider dolayısıyla servera erişen biri senin hassas bilgilerine ulaşabilir
        // bu yüzden appsettingse kritik bilgiler girmiyoruz.
        // bunun için secret.json kullanıyoruz
        // projeye sağ tık --> Manage user secrets
        // bunu yaptığımızda projeye bir secretID atanır. --> projeye çift tıklarsan UserSecretsId tagi içinde göreceksin.
        // C nin altında belli bir dizinde secrets.json dosyası oluşturulur o dosyanın adı bu ID'dir.
        // Bilgisayarım/C/Users/Username/Appdata/Roaming/Microsoft/UserSecrets dizininde
        // dosyalar gizli olabilir gizli dosyaları göster seçeneğiyle bakmak daha iyi olur.
        // bir çok böyle dosya olabilir bunu ID'sinden bulabiliriz.
        // Bahsettiğimiz kritik verileri secrets.json dosyasına koyarız.

        // secrets.jsona da aynı şekilde IConfiguration ve Options patterni ile erişiriz.
        // Önceki derste configlerin appsettingsten çekildiğini öğrenmiştik. Bu süreç aslında otomatik olarak şöyle işliyor
        // önce environmenta sonra secret.jsona eğer oralarda aranılan şey yoksa en son appsettingse bakılır. Environment -> secrets.json -> appsettings.json

        // Peki böyleyse sunucuya gönderdiğimizde secrets.json dosyasındaki bir şey nasıl okunuyor?
        // Environmentlerin içinde değişken olarak bulunuyormuş falan ama detaylı anlatmadı
        // çünkü environment başka bir konu onu sonra öğrenicez.

        readonly IConfiguration _configs;
        public HomeController(IConfiguration configs)
        {
            _configs = configs;
        }
        public IActionResult Index()
        {
           string kullanici = _configs["MailBilgileri:Kullanici"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
