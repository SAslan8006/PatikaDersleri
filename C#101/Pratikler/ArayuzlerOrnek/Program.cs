using System;

namespace ArayuzlerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new();
            System.Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(focus.KacTekerlektenOlusur());
            System.Console.WriteLine(focus.StandartRengine().ToString());

            System.Console.WriteLine("************************");

            Civic civic = new();
            System.Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(civic.KacTekerlektenOlusur());
            System.Console.WriteLine(civic.StandartRengine().ToString());

            System.Console.WriteLine("************************");

            Corolla corolla = new();
            System.Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(corolla.KacTekerlektenOlusur());
            System.Console.WriteLine(corolla.StandartRengine().ToString());

            System.Console.WriteLine("******** Abstract Class *****");

            NewFocus newFocus = new();
            System.Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(newFocus.KacTekerlektenOlusur());
            System.Console.WriteLine(newFocus.StandartRengiNe().ToString());

            System.Console.WriteLine("************************");

            NewCivic newCivic = new();
            System.Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(newCivic.KacTekerlektenOlusur());
            System.Console.WriteLine(newCivic.StandartRengiNe().ToString());

            System.Console.WriteLine("************************");

            NewCorolla newCorolla = new();
            System.Console.WriteLine(newCorolla.HangiMarkaninAraci().ToString());
            System.Console.WriteLine(newCorolla.KacTekerlektenOlusur());
            System.Console.WriteLine(newCorolla.StandartRengiNe().ToString());


        }
    }
}
