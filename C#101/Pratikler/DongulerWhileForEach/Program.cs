using System;

namespace DongulerWhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1,toplam =0;

           while (sayac<=sayi)
           {
               toplam +=sayac;
               sayac++;

           }
           System.Console.WriteLine(toplam / sayi);


        char character ='a';
           while (character<='z')
           {
               Console.Write(character +" ");
               character ++;
           }

           System.Console.WriteLine("***** ForEach ******");

           string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

           foreach (var araba in arabalar)
           {
               System.Console.WriteLine(araba);
           }
        }
    }
}
