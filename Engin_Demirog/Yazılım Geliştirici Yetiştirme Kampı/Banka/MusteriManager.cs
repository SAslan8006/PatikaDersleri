using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class MusteriManager
    {
        public void ParaYatir(Musteri musteri,decimal para)
        {
            Console.WriteLine($"{musteri.MusteriName} hesabına {para} yatırıldı...Toplam Mevduat:{Convert.ToDecimal(musteri.MevduatMiktarı)+para}");
        }
        public void ParaCek(Musteri musteri,decimal para)
        {
            Console.WriteLine($"{musteri.MusteriName} hesabına {para} cekildi...Toplam Mevduat:{Convert.ToDecimal(musteri.MevduatMiktarı) - para}");

        }
        public void Havale(Musteri musteri, decimal para)
        {
            Console.WriteLine($"{musteri.MusteriName} hesabına {para} cekildi...Toplam Mevduat:{Convert.ToDecimal(musteri.MevduatMiktarı) - para}");

        }
        public void Kredi(Musteri musteri)
        {
            Console.WriteLine($"{musteri.MusteriName} Kredi verildi.");
        }
    }
}
