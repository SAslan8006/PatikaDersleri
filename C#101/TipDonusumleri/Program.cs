using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");


            // İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***İmplicit Conversion***");
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Umut Can";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);
            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("***Explicit Conversion***");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // ToString Methodu
            Console.WriteLine("***ToString Methodu***");
            int xx = 6;
            string yy = Convert.ToString(xx);
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            // System.Convert Methodu
            Console.WriteLine("***System.Convert Methodu***");
            string s1 = "10", s2 = "10";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);

            // Parse Methodu
            Console.WriteLine("***Parse Methodu***");



            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double rakam2;
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("Rakam1:" + rakam1);
            rakam2 = Double.Parse(metin2);
            Console.WriteLine("Rakam2:" + rakam2);
            Console.ReadKey();

        }
    }
}
