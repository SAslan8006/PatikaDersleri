using String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            //var a=city.Length; city.Clone();  kolanlama yapılırken referans oluşturmaz
            //var duzenli= string.Format("{0} {1}", city, city);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.Id = 1;
            customer.LastName = "Yobaz";
            customer.City = "Ankara";
            Customer customer2 = new Customer
            { 
                Id = 2,FirstName="Ali",City="Sivas",LastName="Yapıcı"
            }; 
            Console.WriteLine(customer2);

            Console.ReadKey();
        }
    }
}
