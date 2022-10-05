using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    public class NewBaseType
    {
        private static void Main(string[] args)
        {
            // Atama ve İşlemli Atama

            int x = 3;
            int y = 3;
            Console.WriteLine(y);
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantiksal Operatorler
            // || , && , !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            //ilişkisel operatörler
            // <, >, <=, >=, ==, !=
            Console.WriteLine("******** Iliskisel Operatorler **********");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmatik Operatorler
            // /,*,+,-
            Console.WriteLine("******** Aritmatik Operatorler **********");

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);
            sonuc1 = --sayi1;
            Console.WriteLine(sonuc1);

            // % mod alir

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
            Console.ReadKey();

        }
    }
}
