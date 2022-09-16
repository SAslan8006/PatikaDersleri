using System;

namespace DongulerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Sayi Giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i += 2)
            {
                System.Console.WriteLine(i);
            }
            int tekToplam = 0, ciftToplam = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                if (i % 2 != 1)
                {
                    ciftToplam +=i;
                }
            }
            System.Console.WriteLine("Tek Toplam :"+tekToplam);
            System.Console.WriteLine("Cift Toplam :"+ciftToplam);


            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    Console.WriteLine(i);
                    continue;
                    
                }
                if (i==9)
                {
                    break;
                }
            }
        }
    }
}
