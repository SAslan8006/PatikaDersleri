using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HayatAgaci
{
    public class Hayvanlar : Canlilar //public Sealed kalıtım vermesini engellersin 
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte kurabilir.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }
    public class Sürüngenler : Hayvanlar
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
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
   
}
