using System;
using System.Collections;
namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            string gelenDeger;
            int sayi = 0;
            System.Console.Write("Kaç adet Sayı Girmek İstersiniz: ");
            int adet = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 1; i <= adet; i++)
            {
                System.Console.Write("{0}. Sayiyi Giriniz:", i);
                gelenDeger = Console.ReadLine();

                if (SayiKontrol(gelenDeger))
                {
                    sayi = SayiDonustur(gelenDeger);
                    if (AsalMi(sayi))
                    {
                        asalSayilar.Add(sayi);
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(sayi);
                    }
                }
                else
                {
                    i--;
                }
            }
            System.Console.WriteLine("**** Sıralanmış Sayı Grupları ****");

            System.Console.WriteLine("\nAsal Sayılar");
            asalSayilar.SıralanmişListelemeBuyuktenKucuge();




            System.Console.WriteLine("Asal Sayiların Eleman Sayisi:{0}  Ortalaması:{1}", asalSayilar.ElemanSayisi(), asalSayilar.Ortalama());
            System.Console.WriteLine("Asal Olmayan Sayılar");
            asalOlmayanSayilar.SıralanmişListelemeBuyuktenKucuge();
            System.Console.WriteLine("Asal Olmayan Sayiların Eleman Sayisi:{0}  Ortalaması:{1}", asalOlmayanSayilar.ElemanSayisi(), asalOlmayanSayilar.Ortalama());
        }

        static bool AsalMi(int sayi)
        {
            bool asalMi = true;

            for (var i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
            if (sayi < 2)
            {
                asalMi = false;
            }
            return asalMi;
        }

        static int SayiDonustur(string gelenDeger)
        {
            int sayi = 0;
            try
            {
                sayi = int.Parse(gelenDeger);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Lütfen Sayi Giriniz :" + ex.Message);
            }
            return sayi;
        }

        static bool SayiKontrol(string gelenDeger)
        {
            bool sayiMi = false;
            int sayi = 0;
            try
            {
                sayi = int.Parse(gelenDeger);
                sayiMi = true;
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Lütfen Sayi Giriniz :" + ex.Message);
            }
            if (sayi < 0)
            {
                System.Console.WriteLine("Lütfen Negatif Sayi Girmeyiniz");
                sayiMi = false;
            }
            return sayiMi;
        }
    }
    public static class Extension
    {
        public static void SıralanmişListelemeBuyuktenKucuge(this ArrayList array)
        {
            array.Sort();
            array.Reverse();
            foreach (var item in array)
                System.Console.WriteLine(item);
        }
        public static int ElemanSayisi(this ArrayList array)
        {
            return array.Count;
        }
        public static double Ortalama(this ArrayList array)
        {
            int toplam = 0;
            foreach (int item in array)
            {
                toplam += item;
            }
            double ortalama =(double) toplam / array.ElemanSayisi();
            return ortalama;
        }

    }
}
