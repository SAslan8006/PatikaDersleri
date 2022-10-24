using appsettings.json_Dosyası.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace appsettings.json_Dosyası.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
            // IoC providerında bulunan IConfiguration appsettings.json dosyasını okur ve içindeki değerleri getirir.
            // Controller içinde de dependency injection ile IConfigurationu çekerek appsettings içindeki konfigürasyonları kullanırız.
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            #region Indexer ile _configuration içinden veri okuma
            //string metin = _configuration["OrnekMetin"]; // bu şekilde key vererek appsettingsteki ayarları çekebiliyoruz
            //string name = _configuration["Person:Name"];
            //string surName = _configuration["Person:Surname"]; 
            // bu yöntem direk değer odaklı çalışır istediğin değeri getirir.
            #endregion

            #region GetSection ile okuma
            //IConfigurationSection section = _configuration.GetSection("Person");
            //IConfigurationSection section2 = _configuration.GetSection("Person:Name");
            // bu yöntem ise daha fazla bilgi getirir. Bir tür obje getiriyor gibi düşünebilirsin.
            #endregion

            #region Get metodu ile veriyi uygun nesneyle eşleştirme
            // person diye bir class oluşturduk name ve surname propertyleri var.
            // var person = _configuration.GetSection("Person").Get(typeof(Person)); // Person sectionunu typeof Person olarak al diyoruz.
            // bu şekilde uygun bir nesnemiz varsa eşleştirebiliyoruz
            #endregion

            #region Environment'a göre appsettings.json ayarlama 
            // projeye (solutionun altındaki mavi dünya olan) sağ tıklayıp properties dediğimizde
            // uygulamanın çeşitli ayarlarını yaptığımız pecere açılacak.
            // debug içinde environment sekmesinde value kısmında Development yazar
            // Development = Proje geliştirme aşamasında
            // Staging = Proje test aşamasında
            // Production = Proje yayınlanmış
            // kendin custom bir şey de belirleyebilirsin.
            // appsettings.json tüm environmentlarda erişilebilen konfigürasyonları barındırır
            // appsettings.Development.json ise sadece development ortamında konfigürasyonlara erişmeni sağlar
            // appsettings.Staging.json ve appsettings.Production.json da proje o environmentlerde ise erişilecek ayarları bulundurur.
            #endregion
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
