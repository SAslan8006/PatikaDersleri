using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Methodlari
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi= { 23,12,4,86,72,3,11,17};
            Console.WriteLine("****** Sırasız Dizi *******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******* Sıralı Dizi ********");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("******* Array Clear ********");
            //sayıDizisi elemanlarını kullanarak 2. indexten  itibaren 2 elemanı sıfırlar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Revers
            Console.WriteLine("******* Array Revers ********");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //İndexof
            Console.WriteLine("******* Array İndexof ********");            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            Console.WriteLine("******* Array Resize ********");
            Array.Resize<int>(ref sayiDizisi,9);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            sayiDizisi[9] = 99;



            Console.ReadLine();

        }
    }
}
