using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_İkililerin_Toplamı
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aralarında boşluk bırakarak sayılarınızın girişi yapınız[orn: 5 12 13 vb.]: ");
            string sayilar = Console.ReadLine();
            IkiliToplam(sayilar);
            Console.ReadKey();
        }

        public static void IkiliToplam(string sayilar)
        {
            int toplam=0, kontrol = 0, uzunluk = 0;
            string[] Dizi = sayilar.Split(' ');
            uzunluk = Convert.ToInt16(Dizi.Length);
            while (Dizi.Length % 2 != 0)
            {
                uzunluk = Convert.ToInt16(Dizi.Length) - 1;
                kontrol = 1;
                break;
            }            
            
            for (int i = 0; i < uzunluk; i+=2)
            {
                if (Dizi[i] == Dizi[i+1])
                {
                    toplam =Convert.ToInt16(Dizi[i]) + Convert.ToInt16(Dizi[i + 1]);
                    Console.Write($" {toplam*toplam} ");
                }
                else
                {
                    toplam = Convert.ToInt16(Dizi[i]) + Convert.ToInt16(Dizi[i + 1]);
                    Console.Write($" {toplam} ");
                }
            }
            if (kontrol==1)
            {
                Console.Write($" {Dizi.Last()}");
            }
           
               
            
        }

    }
}
    

