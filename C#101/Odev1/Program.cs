using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
            //Soru4();

            void Soru4()
            {
                /*
                Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
                */
                Console.Write("Cümle Giriniz : ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');
                Console.WriteLine("Kelime Sayisi : {0}", words.Count());

                Console.WriteLine("Harf Sayisi : {0}", sentence.Count());
                Console.ReadKey();
            }

        }

        private static void Soru3()
        {

            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.         
            */
            Console.Write("Lütfen cümlenin eleman sayısını giriniz:");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeDizisi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz: ", i + 1);
                kelimeDizisi[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("*** Kelimelerin Cümleye Dönüşümü ***");

            foreach (var kelime in kelimeDizisi)
            {
                Console.Write(Convert.ToString(kelime) + " ");
            }
            Console.ReadKey();
        }

        private static void Soru2()
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.          
           */
            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Lütfen bölümü giriniz:");
            int m = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*** M'ye Eşit yada Tam bölünen Sayıların Listesi ***");

            foreach (var sayi in sayiDizisi)
            {
                if (sayi % m == 0)
                    Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }

        private static void Soru1()
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.           
            */
            Console.Write("Lütfen dizinin eleman sayısını giriniz.");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {                
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*** Çift Sayıların Listesi ***");

            foreach (var sayi in sayiDizisi)
            {
                if (sayi % 2 == 0)
                    Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
