using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerManager =  CustomerManager.CreatAtSingleton();
            customerManager.Save();
        }
    }
    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject = new object();
        private CustomerManager()
        { 
        }

        public static CustomerManager CreatAtSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager==null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;

           // return _customerManager ?? (_customerManager = new CustomerManager());
        }
        public void Save()
        {
            Console.WriteLine("Saved!!!");
        }
    }
}
