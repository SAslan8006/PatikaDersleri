using System;

namespace IkıyeBolunme
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilecekSayiAdedi = 0;
            int sayi, toplam = 0;
            float ortalama;
            int bolunenSayilar = 0;
            Console.Write("Kaç Sayı Gireceksiniz: ");
            string deger = Console.ReadLine();
            if (SayiMi(deger))
            {
                girilecekSayiAdedi = int.Parse(Console.ReadLine());
            }
            for (var i = 1; i <= girilecekSayiAdedi; i++)
            {
                Console.WriteLine(i + ". sayıyı giriniz :");
                string deger1 = Console.ReadLine();
                if (SayiMi(deger) == true)
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi % 2 == 0)
                    {
                        toplam += sayi;
                        bolunenSayilar++;
                    }
                }
                else
                {
                    i--;
                }
            }
            ortalama = toplam / bolunenSayilar;
            System.Console.WriteLine("Sayıların Ortalaması : "+ortalama);

        }
        static bool SayiMi(string sayi)
        {
            try
            {
                Convert.ToInt32(sayi);
                return true;
            }
            catch
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz .");
                return false;
            }
        }
    }
}
