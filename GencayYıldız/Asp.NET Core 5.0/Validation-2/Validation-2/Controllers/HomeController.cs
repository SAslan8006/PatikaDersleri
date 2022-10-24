using Microsoft.AspNetCore.Mvc;

namespace Validation_2.Views
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /* Üç tane kütüphane ekledik. Proje=>add=>client-side library
             * 1- jquery
             * 2- jquery-validate
             * 3- jquery-validation-unobtrusive
             * 
             * Bunlar yüklendikten sonra hangi viewde client tabanlı validation yapılacaksa oraya bu kütüphaneleri dahil ediyoruz.
             */
            return View();
        }
    }
}
