using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "engin", "salih", "Derin" };
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            string[,] regions = new string[5, 3]
            {
                { "İstanbul","Kocaeli","Edirne"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Osmaniye"},
                { "Rize","Trabzon","Bartın"},
                { "İzmir","Mugla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            { for (int j = 0; j <= regions.GetUpperBound(1); j++)
                    Console.Write($"{regions[i,j],-10}");
                Console.WriteLine();
            }
                
            

            
            Console.ReadKey();
        }
    }
}
