using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.            
            */

            ArrayList AsalSayi = new ArrayList();
            ArrayList AsalOlmayan = new ArrayList();
            Regex desen = new Regex("^[0-9]*$");
            //Regex araştırmam sonucu içerisinde rakam varsa yada bu değerler var mı diye kontrol et demektir.
            int sayac = 1;
            while (sayac<21)
            {
                Console.Write($"{sayac}. Sayıyı giriniz:");
                string sayi = Console.ReadLine();
                if ( !desen.IsMatch(sayi) || (Convert.ToInt32(sayi) < 0)) 
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz: Sayı sıfırdan büyük ve harf içermememlidir. ");                    
                }
                else
                {
                    int sayi1 = Convert.ToInt32(sayi);
                    int sonuc = Asalmi(sayi1);
                    if (sonuc == 0)
                    {
                        AsalOlmayan.Add(sayi1);
                        sayac++;                        
                    }
                    else
                    {
                        AsalSayi.Add(sayi1);
                        sayac++;                        
                    }                    
                }
            }
            int asalTop = 0;
            int asalDegilTop = 0;
            AsalSayi.Sort();
            AsalOlmayan.Sort();
            Console.WriteLine();
            Console.WriteLine("***** Asal Sayılar *****");
            foreach (int item in AsalSayi)
            {
                Console.WriteLine(item);
                asalTop = asalTop + item;
            }
            Console.WriteLine();
            Console.WriteLine("***** Asal olmayan Sayılar *****");
            foreach (int item in AsalOlmayan)
            {
                Console.WriteLine(item);
                asalDegilTop = asalDegilTop + item;
            }
            Console.WriteLine();
            Console.WriteLine("***** Klavyeden girilen sayılar hakkında bilgiler *****");
            Console.WriteLine();
            Console.WriteLine($"Klavyeden toplamda {AsalSayi.Count} asal sayı girilmiştir");
            Console.WriteLine($"Asal sayı ortalaması: {asalTop / AsalSayi.Count} ");
            Console.WriteLine();
            Console.WriteLine($"Klavyeden toplamda {AsalOlmayan.Count} asal olmayan sayı girilmiştir");
            Console.WriteLine($"Asal olmayan sayı Ortalaması: {asalDegilTop / AsalOlmayan.Count} ");


            Console.ReadKey();
        }

        private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            if (i == sayi)
            {
                return 1;
            }
            return 0;
        }
    }

    
}
