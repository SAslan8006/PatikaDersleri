using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrencesAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);
            string[] cities = new string[] { "Ankara","Adana","Afyon"};
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            cities[0] = "İstanbul";
            foreach (var item in cities2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
