using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            // List();
            Dictionary<string, string>  dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");
            Console.WriteLine(dictionary["Book"]);
            Console.WriteLine(" İngilizce - Türkçe Sözlük ");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Value,-15} {item.Key,-12}");
            }
            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Book"));

            Console.WriteLine();
            Console.ReadKey();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(cities.Contains("Ankara"));
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Ali" });
            //customers.Add(new Customer { Id = 2, FirstName = "Süleyman" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Ali" },
                new Customer { Id = 2, FirstName = "Süleyman" }
            };

            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Insert(0, customer2);
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, FirstName = "Pamuk" },
                new Customer { Id = 5, FirstName = "Yumoş" }

            });
            Console.WriteLine(customers.Count);
            customers.Remove(customers[0]);

            //customers.Clear();
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} ");
            }
        }

        private static void ArrayList()
        {
            string[] cities1 = new string[2] { "Ankara", "İstanbul" };
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Customer
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
    }
}
