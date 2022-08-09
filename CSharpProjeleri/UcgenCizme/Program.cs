using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.
            Dikkat Edilmesi Gereken Noktalar :
                Kod tekrarından kaçınılmalı
                Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
            */

            Console.Write("Üçgenin Yüksekliğini Giriniz :");
            int n = Int32.Parse(Console.ReadLine());
            UcgenCizme(n+1);
            Console.ReadKey();
        }

        private static void UcgenCizme(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
