using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Facotry2());
            productManager.GetAll();
            Console.ReadKey();

        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);
    }
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nloger");
        }
    }
    public abstract class Caching
    { 
        public abstract void Cache(string data);
    }
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache with MemCache");
        }
    }
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache with RedisCache");
        }
    }
    public abstract class CrossCuttingConcersFactory
    {
        public abstract Logging CreatLogger();
        public abstract Caching CreatCaching();
    
    }
    public class Facotry1 : CrossCuttingConcersFactory
    {
        public override Caching CreatCaching()
        {
            return new RedisCache();
        }

        public override Logging CreatLogger()
        {
            return new Log4NetLogger();
        }
    }
    public class Facotry2 : CrossCuttingConcersFactory
    {
        public override Caching CreatCaching()
        {
            return new RedisCache();
        }

        public override Logging CreatLogger()
        {
            return new NLogger();
        }
    }
    public class ProductManager
    {
        CrossCuttingConcersFactory _crossCuttingConcersFactory;
        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcersFactory crossCuttingConcersFactory)
        {
            _crossCuttingConcersFactory = crossCuttingConcersFactory;
            _logging=_crossCuttingConcersFactory.CreatLogger();
            _caching=_crossCuttingConcersFactory.CreatCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged.");
            _caching.Cache("Data");
            Console.WriteLine("Product Listed!");
        }
    }
}
