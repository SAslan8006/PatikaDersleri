using Dependency_Injection.Services.Interfaces;
using System;
namespace Dependency_Injection.Services
{
    public class ConsoleLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Konsola loglama yapıldı");
        }
    }
}
