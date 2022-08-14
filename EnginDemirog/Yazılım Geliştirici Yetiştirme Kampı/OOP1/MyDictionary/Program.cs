using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> SehirlerPlaka = new MyDictionary<string, string>();
            SehirlerPlaka.Add("80", "Osmaniye");
            SehirlerPlaka.Add("06", "Ankara");
            SehirlerPlaka.Add("34", "İstanbul");

            Console.WriteLine($"Listedeki şehir sayısı: {SehirlerPlaka.Count}");
            Console.WriteLine("-------------------------");
            SehirlerPlaka.ShowList();
            Console.ReadKey();
        }
    }
}
