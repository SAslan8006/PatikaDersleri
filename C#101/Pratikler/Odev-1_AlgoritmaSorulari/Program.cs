using System;

namespace Odev_1_AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
                KullanicidanNAdetSayiAlCiftleriYazdir();
                IkiSayiAlTamBolunenleriYazdir();
                KelimeYazdir();
                KelimeHarfSayisiBul();


        }
        static void KullanicidanNAdetSayiAlCiftleriYazdir()
        {
            Console.Write("Lütfen Pozitif Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 0)
            {
                int girilenSayi = 0;
                for (int i = 0; i < sayi; i++)
                {
                    Console.Write("{0}. Sayıyı Giriniz: ", i + 1);
                    girilenSayi = int.Parse(Console.ReadLine());
                    if (girilenSayi % 2 == 0)
                    {
                        Console.WriteLine(girilenSayi);
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            }
        }
        static void IkiSayiAlTamBolunenleriYazdir()
        {
            Console.Write("Lütfen Pozitif Bir Sayı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Pozitif Bir Sayı Daha Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > 0 && sayi2 > 0)
            {
                int girilenSayi = 0;
                for (int i = 0; i < sayi1; i++)
                {
                    Console.Write("{0}. Sayıyı Giriniz: ", i + 1);
                    girilenSayi = int.Parse(Console.ReadLine());
                    if (girilenSayi % sayi2 == 0)
                    {
                        Console.WriteLine(girilenSayi);
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            }
        }
        static void KelimeYazdir()
        {
            Console.Write("Lütfen Pozitif Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 0)
            {
                string[] girilenKelimeler = new string[sayi];
                for (int i = 0; i < sayi; i++)
                {
                    Console.Write("{0}. Kelimeyi Giriniz: ", i + 1);
                    girilenKelimeler[i] = Console.ReadLine();

                }
                Array.Reverse(girilenKelimeler);
                foreach (var kelime in girilenKelimeler)
                {
                    System.Console.WriteLine(kelime);
                }
            }
            else
            {
                System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz");
            }
        }
        static void KelimeHarfSayisiBul()
        {
            Console.Write("Lütfen Bir Cümle Giriniz: ");
            string cumle = Console.ReadLine();
            string yeniCumle = cumle.Trim().Replace(" ", "");
            System.Console.WriteLine(yeniCumle.Length);

            string[] kelimeler = cumle.Split(" ");

            System.Console.WriteLine(kelimeler.Length);

        }

    }

}
