using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
            Dikkat Edilmesi Gereken Noktalar :
                Kod tekrarından kaçınılmalı
                Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli. 
            */

            Console.Write("Klavyeden en az 2 olacak şekilde fibonaccinin istenilen derinliğini giriniz: ");
            int derinlik = int.Parse(Console.ReadLine());
            fibonacci(derinlik);
            Console.ReadKey();
        }

        private static void fibonacci(int derinlik)
        {
            int a = 0, b = 1, c = 0;
            decimal ort = 1;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < derinlik; i++)
            {
                c = a + b;
                ort +=c;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }            
            Console.WriteLine();
            Console.WriteLine($"fibonaccinin {derinlik} deki sayıların ortalaması: {decimal.Round((ort/derinlik),2)} ");
        }
    }
}
