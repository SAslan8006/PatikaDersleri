using System;

namespace CSharpEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik =32;

            if(sicaklik <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarı Çıkmak için havanın biraz daha ısınmasını bekleyelim");
            }
            else if(sicaklik>=(int)HavaDurumu.Sicak) 
            {
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
                System.Console.WriteLine("Hadi Dışarı Çıkalım");
        }
    }
    enum Gunler
    {
        Pazartesi=1,Salı,Çarşamba,Perşembe,Cuma=23,Cumartesi,Pazar
    }
    enum HavaDurumu{
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
