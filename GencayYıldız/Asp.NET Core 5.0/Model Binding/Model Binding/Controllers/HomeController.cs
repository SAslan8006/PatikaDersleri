using Microsoft.AspNetCore.Mvc;

namespace Model_Binding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
