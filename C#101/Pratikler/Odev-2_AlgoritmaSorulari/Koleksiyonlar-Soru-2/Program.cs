using System;
using System.Collections;
namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] enKucuk = new int[3];
            int[] enBuyuk = new int[3];
            System.Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
            int adet = int.Parse(Console.ReadLine());
            int sayi=0;
            for (var i = 0; i < adet; i++)
            {
                System.Console.Write("{0} Sayiyi Giriniz: ",i+1);
                sayi = int.Parse(Console.ReadLine());
                sayilar[i] = sayi;
            }
            foreach (var item in sayilar)
            {
                
            }
            System.Console.WriteLine("En Büyük 3 Sayi");
            sayilar.BuyuktenKucugeSirala();
            enBuyuk[0]=sayilar[0];
            enBuyuk[1]=sayilar[1];
            enBuyuk[2]=sayilar[2];
            ;
            double ortalama = enBuyuk.Ortalama();
            enBuyuk.EkranaTumunuListele();
            System.Console.WriteLine("Ortalamaları :{0} ",ortalama);

            System.Console.WriteLine("En Küçük 3 Sayi");
            sayilar.KucuktenBuyugeSirala();
            enKucuk[0]=sayilar[0];
            enKucuk[1]=sayilar[1];
            enKucuk[2]=sayilar[2];
            ortalama = enKucuk.Ortalama();
            enKucuk.EkranaTumunuListele();
            System.Console.WriteLine("Ortalamaları :{0} ",ortalama);
            System.Console.WriteLine("*************** Sayılar ****************");
            sayilar.EkranaTumunuListele();


        }
    }
    public static class Extension
    {
        public static void BuyuktenKucugeSirala(this Array array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
        public static void KucuktenBuyugeSirala(this Array array)
        {
            Array.Sort(array);
        }
       public static double Ortalama(this Array array)
        {
            int toplam =0;
            foreach (int item in array)
            {
                toplam += item;
            }
            double ortalama = (double)toplam /array.Length;

            return ortalama;

        }
        public static void EkranaTumunuListele(this Array array)
        {
            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
