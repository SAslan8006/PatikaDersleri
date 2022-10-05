using Abstract_Class.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** InterFace *********");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("**************************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("******** Absract *********");

            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkaAracı().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Console.WriteLine("**************************"); 

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkaAracı().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur());
            Console.WriteLine(civic1.StandartRengiNe().ToString());


            Console.ReadKey();
        }
    }
}
