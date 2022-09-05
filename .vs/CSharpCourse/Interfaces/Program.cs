using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3] 
            { 
                new SqlServerCustomerDal(), 
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                
            }
            
            Console.ReadKey();
        }

        private static void Demo()
        {
            

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesInfo()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirsName = "Süleyman", LastName = "ASLAN", Address = "Ankara" };
            manager.Add(customer);
            Student student = new Student { Id = 1, FirsName = "Süleyman", LastName = "ASLAN", Departmant = "Bilgisayar Bilimleri" };
            manager.Add(student);
            manager.Add(customer);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirsName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirsName);
        }
    }
}
