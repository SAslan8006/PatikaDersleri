using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_And_Metot_Tanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MethodAdi[Parametre Listesi]
            //  {
            //  //Method Komutları
            //  }
            //}

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected 

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 123456;
            calisan1.Departman = "IK";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 654321;
            calisan2.Departman = "IK";

            calisan2.CalisanBilgileri();
            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
