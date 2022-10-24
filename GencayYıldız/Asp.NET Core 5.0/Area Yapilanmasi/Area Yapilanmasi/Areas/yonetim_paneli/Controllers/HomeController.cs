using Microsoft.AspNetCore.Mvc;

namespace Area_Yapilanmasi.Areas.yonetim_paneli.Controllers
{
    [Area("yonetim_paneli")] // controllerların çakışmasını engellemek için Area attribute'u verdik 
    // ne isim verdiğin çok önemli değil ama aynı gruptakilere aynı isim vermen daha iyi
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // area içindeki controllerlara erişim için yeni rota tanımlanması gerekir. --> startup.cs git
            // aşağıya takılma sonra gelicen buraya önce startup.cs'e git
            TempData["veri"] = "veri göndermece";
            return RedirectToAction("Index", "Home", new { area = "fatura_yonetimi" });
            // buradan fatura_yonetimine veri gönderdik  
        }
    }
}
