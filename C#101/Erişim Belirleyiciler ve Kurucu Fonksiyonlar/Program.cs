using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan("Ayşe", "Kara", 123456, "İnsan Kaynakları");

            calisan.calisanBilgileri();

            Console.WriteLine("******* Çalışan 2 ***********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 654321;
            calisan2.Departman = "İnsan Kaynakları";

            calisan2.calisanBilgileri();

            Console.WriteLine("******** Çalışan 3**********");

            Calisan calisan3 = new Calisan("Süleyman","Aslan");       

            calisan3.calisanBilgileri();

            Console.ReadKey();
        }
        class Calisan
        {
            public string Ad;

            public string Soyad;

            public int No;

            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }

            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }


            public Calisan()
            {

            }
            public void calisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı:{0}", Ad);
                Console.WriteLine("Çalışanın Soyadı:{0}", Ad);
                Console.WriteLine("Çalışanın Numarası:{0}", No);
                Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
            }
        }
    }
}
