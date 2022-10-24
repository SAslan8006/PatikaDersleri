using Microsoft.AspNetCore.Mvc;

namespace Route_Yapılanması.Controllers
{
    [Route("[controller]/[action]")]
    // [Route("ana")]
    public class HomeController : Controller
    {
        // [Route("in/{id:int?}")] --> controllerı ana indexi de in olarak isimlendirdik
        // bu şekilde verdiğimizde url ana/in şeklinde olduğunda index actionu tetiklenir. 
        // Burada da constraint yapabiliyoruz örnek olarak nullable int id tanımladık.
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
