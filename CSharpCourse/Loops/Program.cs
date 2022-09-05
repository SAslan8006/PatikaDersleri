using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}",IsPrimeNumber(sayi)?"Asal Sayıdır":"Asal Sayı Değildir");
            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int sayi)
        {
            bool result = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    result = false;
                    continue;
                }

            }
            return result;
        }
    }
}
