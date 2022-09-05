using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
            Console.ReadKey();

        }

    }
    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }
    interface ILogger
    {
        void Log(string message);

    }
    class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged, {message}");
        }
    }
    //Nuget
    class Log4Net
    {
        public void LogMessage(string message) 
        {
            Console.WriteLine($"Log with log4net, {message}");
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }
}
