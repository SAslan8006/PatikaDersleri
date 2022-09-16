using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};
            int[] dizi;
            dizi = new int[5];

            dizi[3]=10;
            renkler[0] ="Mavi";
            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);


            //Döngülerle Dizi
            System.Console.Write("Lütfen Dizinini Eleman Sayısını Girin:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            int toplam=0;
            for (int i = 0; i < diziUzunlugu; i++)
            {
                System.Console.WriteLine("lütfen {0}. sayısı giriniz",i+1);
                sayiDizisi[i] =int.Parse(Console.ReadLine());
            }
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;
            }
            System.Console.WriteLine("Ortalamam: "+ (float)toplam / diziUzunlugu);

        }
    }
}
