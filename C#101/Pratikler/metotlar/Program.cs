using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 2;
            int b = 3;

            System.Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            System.Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc1 = ornek.ArttırVeTopla(a,b);
            System.Console.WriteLine("Arrtır Topla :"+sonuc1);

        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public int ArttırVeTopla(int deger1,int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
