using System;

namespace MetotlarOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız");
            }


            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int sonuc1);
            System.Console.WriteLine(sonuc1);


            //Metot Overloading
            int ifade =999;
            string ifade2 ="9991";
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir(ifade2);
            instance.EkranaYazdir("Musa "+"Uyumaz");
        }
    }

    class Metotlar
    {
        public void Topla(int a,int b,out int toplam){
            toplam = a+b;
        }
        public void EkranaYazdir(string veri){
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            System.Console.WriteLine(veri);
        }
        
        public void EkranaYazdir(string veri1,string veri2){
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
