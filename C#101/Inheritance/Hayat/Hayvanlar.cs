using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HayatAgaci
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte kurabilir.");
        }
        public void SuruHalindeHareket()
        {
            Console.WriteLine("Hayvanlar sürüler halinde hareket eder.");
        }
    }
    public class Sürüngenler :Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kus : Hayvanlar
    {
        public Kus()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }

    public class Ordek : Hayvanlar
    {
        public Ordek()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Yuzmek()
        {
            Console.WriteLine("Ördekler yüzer");
        }
    }
}
