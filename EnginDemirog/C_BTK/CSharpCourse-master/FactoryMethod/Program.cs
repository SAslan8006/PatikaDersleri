using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMager customerMager=new CustomerMager(new LoggerFactory2());
            customerMager.Save();

            Console.ReadKey();
        }
    }
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        { 
            //Business to decide factory
            return new SALogger();
        }
    
    }
    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new LogNetLogger();
        }

    }
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    { 
        void Log();
    }
    public class SALogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with SALogger");
        }
    }
    public class LogNetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with LogNetLogger");
        }
    }
    public class CustomerMager
    {
        private ILoggerFactory _loggerFactory;

        public CustomerMager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Saved!");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
