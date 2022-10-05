using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
            new Customer{ FirstName="Pamuk"}, new Student{ FirstName="Süleyman"},new Person{ FirstName="Zehra" }
            };
            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    { 
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
