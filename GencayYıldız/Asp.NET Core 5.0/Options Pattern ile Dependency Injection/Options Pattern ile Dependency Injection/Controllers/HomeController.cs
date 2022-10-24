using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Options_Pattern_ile_Dependency_Injection.Models;

namespace Options_Pattern_ile_Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configs;
        MailInfo _mailInfo;
        public HomeController(IConfiguration configs, IOptions<MailInfo> mailInfo)
            // startuptan geri geldin burdan devam
            // IConfigden bişey almamıza gerek kalmıyor artık 
        {
            _configs = configs;
            _mailInfo = mailInfo.Value; // bunun içindeki değerleri ver dedik çünkü IOptions farklı bir tür
            // şimdi bu controllerda istediğimiz yerden direk _mailInfo değişkenini kullanabiliriz.
            // bu tür işlemlerde IConfiguration yerine Options pattern kullanıyoruz çünkü daha düzenli
            // ve yapılandırılmış. 
        }
        public IActionResult Index()
        {
            // MailInfo mailInfo = _configs.GetSection("MailInfo").Get<MailInfo>();
            // şimdi biz bu şekilde appsettingsten çekebiliyoruz iyidir hoştur ama her seferinde
            // bunu yapmak uzun iş. Bunun için dependency injection yapıyoruz. IoC yapılanmasının 
            // konteynırına bu ayarları koyuyoruz.
            // Options pattern appsettings.json dosyasındaki konfigürasyonları dependency ınjection ile
            // kullanmamızı sağlayan bir tasarım desenidir.
            // --> startupa geç
            return View();
        }
    }
}
