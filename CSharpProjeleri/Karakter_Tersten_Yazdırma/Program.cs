using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Tersten_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen cümle girişi yapınız: ");
            string cumle = Console.ReadLine();
            KelimeCevir(cumle);
            Console.ReadKey();
        }

        public static void KelimeCevir(string cumle)
        {
            
            string[] Array = cumle.Split(' ');

            foreach (string item in Array)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    Console.Write(item[i]);
                }
                Console.Write(" ");
            }

        }
    }
}
