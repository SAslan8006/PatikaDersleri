using Microsoft.AspNetCore.Mvc;

namespace Kullanıcıdan_Veri_Alma_Yontemleri.Controllers
{
    public class ProductController : Controller
    {
        // URL üzerinden query string olarak veri alma. Not: query stringler url'de açıkça görülür bu yüzden pek güvenli değildir.
        // url şu şekilde olmalı product/takedata?data1=furkan&data2=ince

        #region Parametre olarak alma
        //public IActionResult TakeData(string data1, string data2)
        //{
        //   // parametre olarak alabiliriz
        //    return View();
        //} 
        #endregion

        #region Request uzerinden alma
        //public IActionResult TakeData()
        //{
        //    bool queryString = Request.QueryString.HasValue; // parametre eklenmiş mi eklenmemiş mi kontrol edebiliriz
        //    var query = Request.QueryString; // gelen querystring ile ilgili bilgileri alabiliriz
        //    Request.Query["data1"].ToString();
        //    Request.Query["data2"].ToString();
        //    return View(); 
        //} 
        #endregion

        #region Tanımlı bir model uzerinden alma
        //public IActionResult TakeData(Query query)
        //{
        //    string data1 = query.data1;
        //    string data2 = query.data2;
        //    return View();
        //} 
        #endregion

        // Route üzerinden taşımanın detayları için startup.cs'te endpoints kısmına git. Sonrasında TakeData cshhtml'e de bak.
        public IActionResult TakeData(string id)
        {
            var values = Request.RouteValues;
            return View();
        }
    }

    public class Query
    {
        public string data1 { get; set; }
        public string data2 { get; set; }
    }
}
