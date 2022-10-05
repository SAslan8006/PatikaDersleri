using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id=1,FirstName="Süleyman",LastName="ASLAN",Age=33};
            CustomerDal customerDal=new CustomerDal();
            customerDal.Add(customer);
            Console.ReadKey();
        }
    }
    [ToTable("Customers")]
    [ToTable("TblCustomers")]

    class Customer 
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal 
    {
        [Obsolete("Dont use Add, instead use AddNew method.")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id} {customer.FirstName} {customer.LastName} {customer.Age}");

        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id} {customer.FirstName} {customer.LastName} {customer.Age}");

        }
    }
    [AttributeUsage(AttributeTargets.Property)] //All Yerine Class derse sadece class da kullanılır
    class RequiredPropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] 
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
