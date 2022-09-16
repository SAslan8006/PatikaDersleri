using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            //System.Collections.Generic
            // T=> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                System.Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                System.Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //Liste İçerisinde Arama
            if (sayiListesi.Contains(10))
            {
                System.Console.WriteLine("10 Liste İçerisinde Bulundu");
            }

            //Eleman ile indexe erişme
            System.Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi Listeye Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);
            
            //Listeyi Temizle
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi =new();
            Kullanıcılar kullanici1 = new();
            kullanici1.Isim ="Ayşe";
            kullanici1.Soyisim ="Yılaz";
            kullanici1.Yas =26;
            Kullanıcılar kullanici2 = new(){Isim="Özcan",Soyisim="çalışkan",Yas=26};

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas =24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı: "+kullanici.Isim);
                System.Console.WriteLine("Kullanıcı Soyadı: "+kullanici.Soyisim);
                System.Console.WriteLine("Kullanıcı Yaşı: "+kullanici.Yas);
            }
            yeniListe.Clear();
        }
    }
    public class Kullanıcılar{
       public string Isim { get; set; }
       public string Soyisim { get; set; }
       public int Yas { get; set; }
       
       
       

    }
}
