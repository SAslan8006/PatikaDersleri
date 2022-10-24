using Microsoft.AspNetCore.Mvc;
using MVC_Altyapisi.Models;
using MVC_Altyapisi.Models.ViewModels;
using System.Collections.Generic;
using System.Text.Json;

namespace MVC_Altyapisi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //***** return olarak verebileceğimiz resultlar.*****
            // burada çağırıp return ettiğimiz fonksiyonlar base classta (Controller classı) tanımlıdır
            #region View()
            //return View(); // --> İlgili action ismiyle birebir aynı isimde olan viewi tetikler
            // return View("return edilmesi istenen viewin ismi"); // belirtilen viewi döndürür
            // View() Fonksiyonu viewdeki cshtml dosyasını render ederek ViewResult döndürür. 
            #endregion

            #region PartialView()
            /* Bazı sayfalarda sayfa yeniden yüklenmeden sayfa içinde işlem vs yapabiliyorsun. Böyle sayfa içinde ufak işlemler yapılırken ajax kullanılır.
             * PartialView Viewden farklı olarak client tabanlı yapılan Ajax isteklerinde kullanılır.
             ViewResult gelirken normal viewimiz render edilmeden önce ViewStart.cshtml dosyası render edilir.
            ViewStart dosyası içinde genel tasarım olan layoutu tutar.
            PartialViewResult ise bu dosyayı baz almadan sadece normal viewimizi render eder.
            Böylece sayfanın tümü render edilmez sadece gerekli olan kısım render edilir. Performans açısından tasarruf edilmiş olur*/
            #endregion

            #region Json()
            /* Üretilen datayı json formatında döndürür. Hangi değeri döndüreceksen onu parametre olarak verirsin */
            //Json(new Product
            //{
            //    Id = 5,
            //    ProductName = "Kalem",
            //    Quantity = 15,
            //});
            #endregion

            #region EmptyResult Nesnesi
            // Response var ama bir result yok
            // return new EmptyResult();
            #endregion

            #region Content()
            // Content("metin döndürür döndürülen değer render edilmez text formatında gelir");
            #endregion

            var products = new List<Product>
            {
                new Product{ Id = 1, ProductName = "A", Quantity = 10},
                new Product{ Id = 2, ProductName = "B", Quantity = 15},
                new Product{ Id = 3, ProductName = "C", Quantity = 20},
            };

            //***** Viewe veri gönderme yöntemleri *****//
            #region Model bazlı veri gönderme
            //return View(products);  // index.cshtml'e git orada nasıl yakaladığımıza bak
            #endregion

            #region Veri Taşıma Kontrolleri

            #region ViewBag
            // Viewe gönderilecek datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.
            // ViewBag.urunler = products;
            #endregion

            #region ViewData
            // Viewbag gibi actiondaki datayı viewe taşır fakat viewbag dynamic değişkenle taşırken. Bu boxing yaparak taşır.
            // Dolayısıyla viewde datanın unboxing edilmesi gereklidir.
            // ViewData["products"] = products;
            #endregion

            #region TempData
            /* ViewDatada olduğu gibi boxing ve unboxing vardır. Bir response göndermeden önce actionlar arasında geçiş yapabiliyoruz.
             * Örneğin Index'in içinde başka bir action çağrılabilir. Indexteki verinin öbür actiona taşınması için viewdata kullanılır.
             * Viewdata veriyi sessionlar ve cookieler üzerinden taşır. Diğer taşıma yöntemleri ise öbür actiona taşınamaz null olarak geçer */


            /* Eğer liste gibi karmaşık bir veri grubu taşınacaksa önce veriyi serialize etmemiz gerekir.*/
            // string data = JsonSerializer.Serialize(products); // data serialize edilince string haline gelir.
            // TempData["products"] = data; // json string haline gelen data boxinglendi.
            // return RedirectToAction("Index2"); // Bu metoda parametre olarak yönlendirme yapılacak actionu veririz.
            // Eğer action farklı bir controllerin içindeyse metoda ikinci parametre olarak controllerin ismini veririz.
            // --> Index2'ye git
            #endregion

            #endregion

            return View();
        }

        [NonAction]
        public void x()
        {
            /* Controller içinde herhangi bir işi yapacak metot bulunmamalıdır.
             * Buradaki metotlar action metot olup sadece requestleri karşılamalıdır.
            Fakat illa ki bir işlem için kullanılacaksa başına NonAction attribute'u eklenerek
            bu metotun bir request karşılamayacağı bildirilmelidir. */
        }

        public IActionResult Index2()
        {
            string data = TempData["products"].ToString(); // data unboxing edilip stringe dönüştürüldü
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data); // json string formatından product listesine çevrildi.
            return View();
        }

        public IActionResult GetProducts()
        {
            /*** Tuple ***/ 
            // veri taşıma yöntemleriyle tüm verileri tek tek taşımak performans açısından olumsuzdur. Bunun yerine viewmodeller veya tuple kullanılmalıdır
            Product product = new Product {

                Id = 1,
                ProductName = "ürün",
                Quantity = 10,
            };

            User user = new User{
                
                Id = 1,
                Name = "furkan",
                LastName = "ince",
            };

            /* sayfaya birden fazla model göndermek için tuple kullanılabilir */
            var userProduct = (product, user); // bu şekilde bir syntaxta verdiğimizde otomatik olarak tuple nesnesi olarak algılanır
            return View(userProduct);
        }
    }
}
