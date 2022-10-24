using Microsoft.AspNetCore.Mvc;
using Tuple_Nesne_Post_Etme_ve_Yakalama.Models;

namespace Tuple_Nesne_Post_Etme_ve_Yakalama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var tuple = (new Product(), new User()); // Önce tuple'ı burada tanımlamamız gerekiyor ki indexte yakalayabilelim. Indexte çağırırken burada tanımladığımız sırayla çağırmaya dikkat et!!!
            return View(tuple);
        }

        [HttpPost]
        public IActionResult Index([Bind(Prefix = "Item1")]Product product, [Bind(Prefix = "Item2")]User user) // Veriyi çekerken sırasına göre kaçıncı item olduklarını belirterek bind yapıyoruz.
        {
            
            return View();
        }

 
    }
}
