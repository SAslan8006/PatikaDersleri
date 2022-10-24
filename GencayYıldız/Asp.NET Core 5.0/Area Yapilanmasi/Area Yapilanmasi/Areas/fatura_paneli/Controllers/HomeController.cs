using Microsoft.AspNetCore.Mvc;

namespace Area_Yapilanmasi.Areas.fatura_paneli.Controllers
{
    [Area("fatura_paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["veri"];
            return View();
        }
    }
}
