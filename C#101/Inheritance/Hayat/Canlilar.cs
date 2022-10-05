using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.HayatAgaci
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }
    }
}
