using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Property_Kavramı
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriGetir();
            Console.ReadKey();
        }
        class Ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;
            public string Isim 
            {
                get { return isim; }
                set { isim = value; } 
            }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
            public int Sinif1 { get => sinif; set => sinif = value; }


            public int Sinif
            {
                get => Sinif1;
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Sınıf en az 1 olabilir.");
                        Sinif1 = 1;
                    }
                    else
                    {
                        Sinif1 = value;
                    }
                }
            }


            public Ogrenci()
            {

            }

            public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }

            public void OgrenciBilgileriGetir()
            {
                Console.WriteLine("********* Öğrenci Bilgileri ***********");
                Console.WriteLine("Öğrenci Adı    :{0}", this.Isim);
                Console.WriteLine("Öğrenci Soyadı :{0}", this.Soyisim);
                Console.WriteLine("Öğrenci No     :{0}", this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıfı :{0}", this.Sinif);
            }

            public void SinifAtlat()
            {
                this.Sinif = this.Sinif + 1;
            }

            public void SinifDusur()
            {
                this.Sinif = this.Sinif - 1;
            }
        }
    }
}
