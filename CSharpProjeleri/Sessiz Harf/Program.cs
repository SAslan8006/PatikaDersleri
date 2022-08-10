using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kelimeleri giriniz: ");            
            string[] Array = Console.ReadLine().Split();
            KelimeKontrol(Array);
            Console.ReadKey();
        }

        private static void KelimeKontrol(string[] array)
        {
            foreach (var item in array)
            {
                bool def = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (harfKontrol(item[i]) == harfKontrol(item[i - 1]))
                        def = true;
                }
                Console.Write(def + " ");
            }

            bool harfKontrol(char c)
            {
                return !"aeıioöuü".ToCharArray().Contains(c);
            }

        }
    }
}
