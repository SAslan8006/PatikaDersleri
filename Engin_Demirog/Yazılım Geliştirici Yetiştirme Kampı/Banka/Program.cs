using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri { TC = 1, MusteriName = "Ahmet", MevduatMiktarı = 12220, MusteriSoyadı = "Amasya" };
            Musteri m2 = new Musteri { TC = 2, MusteriName = "Süleyman", MevduatMiktarı = 12330, MusteriSoyadı = "Taş" };
            Musteri m3 = new Musteri { TC = 3, MusteriName = "Pamuk", MevduatMiktarı = 13335, MusteriSoyadı = "İthal"};
            Musteri m4 = new Musteri { TC = 4, MusteriName = "Nur", MevduatMiktarı = 12225, MusteriSoyadı = "Yerli" };
            Musteri[] products = new Musteri[] { m1, m2, m3, m4 };
            foreach (Musteri item in products)
            {
                Console.WriteLine($"{item.TC,-5} {item.MusteriName,-15} {item.MusteriSoyadı,-15} {item.MevduatMiktarı,-15}");
            }
            MusteriManager musteriislemleri = new MusteriManager();
            musteriislemleri.ParaYatir(m1,300);
            musteriislemleri.ParaCek(m4, 600);
            musteriislemleri.Havale(m2, 300);
            musteriislemleri.Kredi(m3);

            Console.ReadKey();
        }
    }
}
