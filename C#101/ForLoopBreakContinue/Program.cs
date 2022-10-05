using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //girilen sayıya kadar olan tek sayıların yazdırılması
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine("i");
            }

            //1-1000 arasındaki tek ve çift sayıların kendi içlerinde toplamların yazdırılması
            int tekToplam = 0, ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; //tekToplam = tekToplam + i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek toplam :" + tekToplam);
            Console.WriteLine("Çift toplam :" + ciftToplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

            //for (;;)    //sonsuzluk
            //{

            //}
            Console.ReadKey();
        }
    }
}