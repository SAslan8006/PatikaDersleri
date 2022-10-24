using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appsettings.json_Dosyası
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => //appsettings olarak verilen json dosyaları burada mimari ayağa kalkılırken rame geçer. 
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(b => b.AddJsonFile("ekAyar.json")) // kendimiz bir dosya eklemek istiyorsak bu şekilde ekleriz
            // appsettings ön tanımlı özel bir dosyadır o kendiliğinden zaten eklenir.
            // --> homecontrollera git
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
