using System;

namespace DizilerArraySinifiMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort 
            int[] sayiDizisi ={23,12,4,86,72,3,11,17};
            System.Console.WriteLine("**** Sırasız Liste ******");
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);    
            }
            System.Console.WriteLine("**** Sıralı Liste ******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //clear
            System.Console.WriteLine("***** Array Clear ********");
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //Reverse 
            System.Console.WriteLine("***** Reverse ******");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            //indexOf
            System.Console.WriteLine("***** Index OF ******");
            var index = Array.IndexOf(sayiDizisi,23);

            System.Console.WriteLine(index);


            //Resize 
            System.Console.WriteLine("***** Resize ******");
            Array.Resize<int>(ref sayiDizisi,9);

            sayiDizisi[8] =99;
            
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
        }
    }
}
