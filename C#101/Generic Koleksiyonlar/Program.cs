using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Koleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            //using System.Collections.Generic;
            //T->Oject Türüdür.  
            //--------------Generic List---------------------


            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(43);
            sayiListesi.Add(48);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("yeşil");

            //Count 
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //----foreach ve List.ForEach ile elemanları ekrana yazdırma

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //foreach kısa kullanım hali => öyle ki anlamındadır
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //------Listeden Eleman Çıkarma--------------

            sayiListesi.Remove(48);
            renkListesi.Remove("yeşil");

            sayiListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //foreach kısa kullanım hali => öyle ki anlamındadır
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //-----Liste İçerisinde Arama-----

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("bulundu");
            }
            else
                Console.WriteLine("bulunamadı");

            //-----Eleman ile İndexe Erişme---------

            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //----Diziyi List'e Çevirme---------

            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanlistesi = new List<string>(hayvanlar);


            //-----Listeyi Temizleme-------

            hayvanlistesi.Clear();

            //-------Listeye nesne atamak-----
            List<kullanicilar> kullanicilarlistesi = new List<kullanicilar>();
            kullanicilar kullanicilar1=new kullanicilar();
            kullanicilar1.Isim = "Ayşe";
            kullanicilar1.Soyisim = "Yılmaz";
            kullanicilar1.Yas = 26;

            kullanicilar kullanicilar2 = new kullanicilar();
            kullanicilar2.Isim = "Süleyman";
            kullanicilar2.Soyisim = "ASLAN";
            kullanicilar2.Yas = 33;

            kullanicilarlistesi.Add(kullanicilar1);
            kullanicilarlistesi.Add(kullanicilar2);

            List<kullanicilar> yeniliste = new List<kullanicilar>();
            yeniliste.Add(new kullanicilar()
            {
                Isim = "Deniz",
                Soyisim="Arda",
                Yas=24
            });

            foreach (kullanicilar item in kullanicilarlistesi)
            {
                Console.WriteLine($"Kullanıcı İsmi: {item.Isim}");
                Console.WriteLine($"Kullanıcı Soyisim: {item.Soyisim}");
                Console.WriteLine($"Kullanıcı Yaşı: {item.Yas}");

            }
            yeniliste.Clear();

            Console.ReadKey();       
        }
        public class kullanicilar
        {
            private string isim;
            private string soyisim;
            private int yas; 
            
            //encapsule etmek
            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
