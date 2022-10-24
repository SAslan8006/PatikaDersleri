using Microsoft.AspNetCore.Mvc;
using Model_Binding.Models;

namespace Model_Binding.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult CreateProduct() // Bir action metot aksi belirtilmedikçe default olarak get türünden istekleri karşılar
        {
            // Model binding çift yönlüdür. Sen buradan bir nesne oluşturup yollarsan formda yaptığın değişikler buradan yolladığın örnekte olur
            // yani yeni nesne oluşmaz oluşturulmuş nesne değişir.
            Product product = new Product();
            return View(product);
        }
        #region Parametre üzerinden verileri yakalama
        //[HttpPost] // post geldiğinde verinin yakalanması için aynı actionun postlu versiyonunu yazdık. Yukardaki get ile sayfanın görüntülenmesi içindi. Gelen datalar ise parametrelerde yakalanır.
        //public IActionResult CreateProduct(string txtProductName, string txtQuantity) // datanın name'i ile parametreler aynı isimde olmalı
        //{
        //    return View();
        //} 
        #endregion

        [HttpPost]
        public IActionResult CreateProduct(Product product) // parametre kısmına (IFormCollection degisken) verirsek de koleksiyon olarak çekiyor
        {
            /* Sistem otomatik model binding yapıyor*/
            return View();
        }
    }
}
