using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama Ve İşlemli Atama
            System.Console.WriteLine("****** Atama Ve İşlemli Atama *******");
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);


            Console.WriteLine("****** Mantıksal Operatörler*******");
            //Matıksal Operatörler 
            // || && !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                System.Console.WriteLine("Perfect");
            }
            if (isCompleted || isSuccess)
            {
                System.Console.WriteLine("Great!");
            }
            if (isSuccess && !isCompleted)
            {
                System.Console.WriteLine("Fine!");
            }

            //İlişkisel Operatörler 
            //< > <= >= == !=
            Console.WriteLine("****** İlişkisel Operatörler *******");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            System.Console.WriteLine(sonuc);
            sonuc = a > b;
            System.Console.WriteLine(sonuc);
            sonuc = a >= b;
            System.Console.WriteLine(sonuc);
            sonuc = a <= b;
            System.Console.WriteLine(sonuc);
            sonuc = a == b;
            System.Console.WriteLine(sonuc);
            sonuc = a != b;
            System.Console.WriteLine(sonuc);

            Console.WriteLine("****** Aritmetik Operatörler *******");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1--;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            System.Console.WriteLine(sonuc1);


            //Mod Alma %
            int sonuc2 = 20%3;
            System.Console.WriteLine(sonuc2);

        }
    }
}
