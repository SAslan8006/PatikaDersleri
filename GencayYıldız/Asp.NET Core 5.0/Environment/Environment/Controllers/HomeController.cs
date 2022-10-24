using Environment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Environment.Controllers
{
    public class HomeController : Controller
    {
        // Environment Nedir?
        // ASPNETCORE_ENVIRONMENT uygulamanın hangi ortamda ayağa kalkacağını belirtir
        // environmentleri açmak için üst menüden debug/environment debug properties
        //

        public IActionResult Index()
        {
            // runtime'da hangi environmentte olduğumuzu yakalamak için IoC'den dependency injection ile IWebHostEnvironment arayüzü kullanılır.
            return View();
        }
        readonly IWebHostEnvironment _env;
        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
            
        }

        public IActionResult Privacy()
        {
            // bunların hepsi true false döner bu sayede hangi environmentte olduğumuzu anlarız
            // ilginç bir şekilde direk hangi envdeyiz diye sorabileceğimiz bir metot yok
            _env.IsDevelopment(); 
            _env.IsStaging();
            _env.IsProduction();
            _env.IsEnvironment("abc"); // başka bir envde isek parametre olarak veriyoruz 
            // yani burada abc adlı envde miyiz diye sorduk

            // secret managerda verdiğimiz şeyler local bilgisayarda kalacaktır
            // bu yüzden kritik veriler daima environmentta tutulmalıdır.
            // environment publish çıktısında bulunmaz bu değerleri hostingde veya cloudda vermen gerekiyor.
            // hosting veya cloudda tam olarak nasıl vereceğiz anlamadım? sanırım valuelerini vermemiz gerekiyor envlerin

            // cshtml içinde envler için --> Views/Home/Index

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
