using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler 
            // * Public => Her yerden erişilebilir programın herhangi bir noktasından erişilebilir
            // * Private => Sadece tanımlandığı sınıf içerisinde erişilebilir
            // * Internal => Kendi bulunduğu proje içerisinde erişilebilir
            // * Protected => Sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan miras alan sınıflar tarafından erişilebilir


            System.Console.WriteLine("************ Çalışan 1 ***********");
            Calisan calisan1 = new Calisan("Ayşe","Kara",23425636,"İnsan Kaynakları");
            calisan1.CalisanBilgiler();
            
            System.Console.WriteLine("************ Çalışan 2 ***********");
            Calisan calisan2 = new();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgiler();

            System.Console.WriteLine("************ Çalışan 3 ***********");
            Calisan calisan3 = new("Zikriye","Ürkmez");
            calisan3.CalisanBilgiler();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan ()
        {
            
        }
        public void CalisanBilgiler()
        {
            System.Console.WriteLine("Çalışan Adı:{0}", Ad);
            System.Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            System.Console.WriteLine("Çalışan Numarası:{0}", No);
            System.Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }
}
