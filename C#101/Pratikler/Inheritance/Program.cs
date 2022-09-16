using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                      Canlılar
            //                          |
            //         Bitkiler                        Hayvanlar
            //     |               |               |               |
            //  Tohumlu        Tohumsuz       Surungenler        Kuşlar

            TohumluBitkiler tohumluBitki = new();

            tohumluBitki.TohumlaCogalma();

            System.Console.WriteLine("*******************");

            Kuslar marti = new();
            marti.Ucmak();
        }
    }
}
