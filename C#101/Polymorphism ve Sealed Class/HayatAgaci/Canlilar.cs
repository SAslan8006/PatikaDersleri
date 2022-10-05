using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HayatAgaci
{
    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }
        public virtual void UyaranlaraTepki() 
        {
            Console.WriteLine("Canlılar Uyaranlara tepki verir.");
        }
    }
}
