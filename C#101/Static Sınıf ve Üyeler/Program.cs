using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Sınıf_ve_Üyeler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan.CalisanSayisi);

            Calisan calisan3 = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan.CalisanSayisi);
            Calisan calisan4 = new Calisan("Ayşe", "Yılmaz", "IK");
            Calisan calisan5 = new Calisan("Süleyman", "Aslan", "IK");
            Console.WriteLine("Çalışan Sayısı :{0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Çıkar(300, 200));
            Console.ReadKey();
        }
        class Calisan
        {
            private static int calisanSayisi;
            public static int CalisanSayisi { get => calisanSayisi; }
            private string Isim;
            private string Soyisim;
            private string Departman;

            static Calisan()
            {
                calisanSayisi = 0;
            }

            public Calisan(string ısim, string soyisim, string departman)
            {
                Isim = ısim;
                Soyisim = soyisim;
                Departman = departman;
                calisanSayisi++;
            }
        }


        static class Islemler
        {
            public static long Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public static long Çıkar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }
    }
}
