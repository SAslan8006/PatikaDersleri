
using Inheritance.HayatAgaci;
using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //                          Canlılar
            //          Bitkiler            |             Hayvanlar
            //     |                |           |              |
            //     Tohumlar     Tohumsuz    Sürüngenler     Kuslar
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumluBitki.Beslenme();
            //tohumluBitki.Bosaltim();
            //tohumluBitki.Solunum();
            //tohumluBitki.FotosentezYapmak(); //protected ile kapattık 
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**********************");
            
            Kus marti = new Kus();
            //marti.Solunum();
            //marti.Beslenme();
            //marti.Bosaltim();
            //marti.Adaptasyon();
            marti.Ucmak();

            Console.ReadKey();
        }
    }
}
