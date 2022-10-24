using Microsoft.AspNetCore.Mvc;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /* İkinci bir farklı validation yöntemi için paket managerdan FluentValidation.AspNetCore indirdik. MVC'deki modelstate yapısıyla
         * entegre geliştirilmiştir. Bu servisi uygulamaya entegre etmek için startup.cs'e git */
    }
}
