using Inheritance.HayatAgaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Ordek ordek = new Ordek();
            //ordek.Solunum();
            //ordek.Beslenme();
            //ordek.Bosaltim();
            ordek.SuruHalindeHareket();
            ordek.Yuzmek();
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
