using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliHarfler = {'a','e','i','ı','o','ö','u','ü'};
            System.Console.Write("Lütfen Bir Cümle Giriniz: ");
            string cumle = Console.ReadLine();
            ArrayList cumleninSesliHarfleri =new();
            string kucukHarfliCumle = cumle.ToLower(); 
            for (var i = 0; i < kucukHarfliCumle.Length; i++)
            { 
                for (var j = 0; j < sesliHarfler.Length; j++)
                {
                    if (kucukHarfliCumle[i] == sesliHarfler[j])
                    {
                        cumleninSesliHarfleri.Add(sesliHarfler[j]);
                    }
                }
            }
            System.Console.WriteLine("Sesli Harfleri Listeledik");
            cumleninSesliHarfleri.ArrayListele();
        }
    }
    public static class Extension
    {
        public static void ArrayListele(this ArrayList array)
        {
            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
