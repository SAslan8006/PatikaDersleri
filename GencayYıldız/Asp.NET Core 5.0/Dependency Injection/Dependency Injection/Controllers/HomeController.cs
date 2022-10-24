using Dependency_Injection.Models;
using Dependency_Injection.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        readonly ILog _log;
        public HomeController(ILog log) // Ctorda bu şekilde containerın içindeki herhangi bir şeyi alabiliyoruz. Burada containera diyoruz ki ILog olarak ne tutuyosan onu bana getir.
        {
            _log = log;
        }
        public IActionResult Index()
        {
            _log.Log(); // Dependency injection yapılmış oldu ve loglama türü değiştiği zaman burada hiçbir şeyi ellemeden sadece containerin ILog olarak tuttuğu loglamayı değiştirmemiz yeterli olacak.

            return View();
        }

        public IActionResult Privacy([FromServices]ILog log) // action bazlı nesne talebi de bu şekilde attribute belirtilerek yapılır.
        {
            // View bazlı nesne talebi için --> Index.cshtml git
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
