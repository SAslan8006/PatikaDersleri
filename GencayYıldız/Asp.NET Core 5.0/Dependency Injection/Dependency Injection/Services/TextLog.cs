using Dependency_Injection.Services.Interfaces;
using System;

namespace Dependency_Injection.Services
{
    public class TextLog : ILog
    {
        public TextLog(int x)
        {

        }

        public void Log()
        {
            Console.WriteLine("Text dosyasına loglama yapıldı");
        }
    }
}
