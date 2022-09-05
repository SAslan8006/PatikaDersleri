using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Saved();

            Console.ReadKey();
        }
    }
    class Logging:ILogging
    {
        public void Log() 
        {
            Console.WriteLine("Logged");
        }

    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }

    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("CheckUser");
        }

    }

    internal interface IAuthorize
    {
        void CheckUser();
    }
    class Validation : IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validate");
        }

    }

    internal interface IValidate
    {
        void Validate();
    }
    class CustomerManager 
    {
        //private ILogging _logging;
        //private ICaching _caching;
        //private IAuthorize _authorize;

        //public CustomerManager(ILogging logging, ICaching caching, IAuthorize authorize)
        //{
        //    _logging = logging;
        //    _caching = caching;
        //    _authorize = authorize;
        //}
        private CrossCuttongConcernsFacede _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttongConcernsFacede();
        }
        public void Saved()
        {
            //_logging.Log();
            //_caching.Cache();
            //_authorize.CheckUser();
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Validation.Validate();
            Console.WriteLine("Saved");
        }

    }
    class CrossCuttongConcernsFacede
    { 
        public ILogging Logging;  
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidate Validation;

        public CrossCuttongConcernsFacede()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
            Validation = new Validation();
        }
    }

}
