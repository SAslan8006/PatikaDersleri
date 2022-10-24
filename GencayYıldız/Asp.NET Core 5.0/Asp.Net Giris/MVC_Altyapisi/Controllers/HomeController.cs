using Microsoft.AspNetCore.Mvc;

namespace MVC_Altyapisi.Controllers
{
    public class HomeController : Controller /* request alabilmesi ve response döndürebilmesi için
                                              * controllerdan türemesi gerekir */
    {
        public IActionResult Index() /* Action metotlar controllera gelen isteği karşılayan ve gerekli işlemleri gerçekleştiren metotlardır */
        {
            return View(); 
        }
    }
}
