using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    /***** IoC Inversion of Control (kontrol�n ters �evrilmesi) *****
     * Baz� durumlarda s�n�f�m�z i�inde �ok fazla aray�z vsye referans vermemiz gerekebilir.
     * Bu gibi durumlarda tek tek dependency injection yazmak yerine
     * IoC yap�s� kurulur. IoC Containerinin i�ine gerekebilecek t�m t�rler konur ve gerekti�i zaman i�inden �a�r�l�r.
     * IoC yap�lanmas�n� sa�layan �e�itli frameworkler vard�r (Structuremap, AutoFac, Ninject...)
     * Ayn� zamanda .Net Core mimarisinin i�inde de bir built-in konteyner mevcuttur
     * Built-in konteyner i�ine gelecek �eyleri 3 farkl� davran��la alabilir.
     * 
     * 1-Singleton
     * Uygulama �ap�nda tek bir nesne olu�turur ve t�m taleplere o nesne d�ner.
     * 
     * 2-Scoped
     * Request ba��na bir nesne �retilir ve o requestin pipeline'�nda olan t�m isteklere o nesne g�nderilir.
     * 
     * 3-Transient
     * Her requestin her bir talebine yeni bir nesne �retir g�nderir.
     * 
     *  --> KonteynerOrnek class�na git 
     */
}
