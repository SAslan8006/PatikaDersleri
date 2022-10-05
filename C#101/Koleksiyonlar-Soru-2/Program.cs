using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
            ortalama toplamlarını console'a yazdıran programı yazınız. 
            (Array sınıfını kullanarak yazınız.)
             */

            int[] sayilar = new int[20];
            int[] buyuksayi=new int[3];
            int[] kucuksayi = new int[3];


            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i+1}. Sayıyı giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);
            kucuksayi[0] = sayilar[0];
            kucuksayi[1] = sayilar[1];
            kucuksayi[2] = sayilar[2];
            int topla = 0;
            Console.WriteLine("***** Küçük Sayıların Listesi *****");
            foreach (int sayi in kucuksayi)
            {
                Console.WriteLine(sayi);
                topla = topla + sayi;
            }
            Console.WriteLine($"Küçük sayıların toplamı: {topla}");
            Console.WriteLine($"Küçük sayıların ortalaması: {topla/3}");

            
            buyuksayi[0] = sayilar[17];
            buyuksayi[1] = sayilar[18];
            buyuksayi[2] = sayilar[19];
            int topla2 = 0;
            Console.WriteLine("***** Küçük Sayıların Listesi *****");
            foreach (int sayi in buyuksayi)
            {
                Console.WriteLine(sayi);
                topla2 = topla2 + sayi;
            }
            Console.WriteLine($"Büyük sayıların toplamı: {topla2}");
            Console.WriteLine($"Büyük sayıların ortalaması: {topla2 / 3}");


            Console.ReadKey();
        }
    }
}
