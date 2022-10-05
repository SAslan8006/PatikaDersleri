using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 1; //1 byte
            sbyte c = 1; //1 byte

            short s = 2;  //2 byte
            ushort us = 2;  //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 4;  //4 byte
            Int32 i32 = 4;  //4 byte
            Int64 i64 = 8;  //8 byte

            uint ui = 4; //4 byte
            long l = 8; //8 byte
            ulong ul = 8; //8 byte

            //Reel Sayılar
            float f = 4; //4 byte
            double d = 8; //8 byte
            decimal de = 16; //16 byte

            char ch = '2'; //2 byte
            string str = "Okan"; //sinirsiz
            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // Objeler ust turlerdir, her seyi tanimlayabiliriz.
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler

            string str1 = string.Empty; //Degeri bos bir string tanımlama ya da = null; yapılabilir.
            str1 = "Okan Coskun";
            string ad = "Okan";
            string soyad = "Coskun";
            string ad_soyad = ad + " " + soyad;
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(ad_soyad);

            //integer tanimlama sekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10 < 2;

            // Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + " " + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            // Parse string donusumler icin kullanilir.
            int int22 = int20 + int.Parse(str20); // Çıktısı 40

            // datetime

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour1 = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(hour1);
            Console.ReadKey();

        }
    }
}
