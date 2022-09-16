using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10,"Musa Uyumaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Çoşar");

            System.Console.WriteLine("****** Eleamnlara Erişim *******");
            System.Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
                System.Console.WriteLine(item);
                

            //count
            System.Console.WriteLine("**** Count *****");
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine("**** Contains ****");
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));
                
            //Remove
            System.Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                System.Console.WriteLine(item);

            //Keys
            System.Console.WriteLine("***** Keys *****");
            foreach (var item in kullanicilar.Keys)
                System.Console.WriteLine(item);

            //Values
            System.Console.WriteLine("***** Values *****");
            foreach (var item in kullanicilar.Values)
                System.Console.WriteLine(item);
        }
    }
}
