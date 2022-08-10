using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aralarında boşluk bırakarak sayılarınızın girişi yapınız[orn: 5 12 13 vb.]: ");
            string sayilar = Console.ReadLine();
            OzelToplam(sayilar);
            Console.ReadKey();
        }

        public static void OzelToplam(string sayilar)
        {            
            string[] Dizi = sayilar.Split(' ');
            int toplam = 0,sayi=0,toplam1=0;
            for (int i = 0; i < Dizi.Length; i ++)
            {
                sayi = Convert.ToInt16(Dizi[i]);
                if  (sayi<67)
                {
                    toplam1 = (67-sayi)+ toplam1;
                }
                else
                {
                    toplam = (int)Math.Pow(Math.Abs(sayi - 67),2);
                }
            }  
                Console.WriteLine($" {toplam1}  {toplam} ");

        }
    }
}
