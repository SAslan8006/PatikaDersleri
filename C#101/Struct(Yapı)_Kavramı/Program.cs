using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Yapı__Kavramı
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı : {0}",dikdortgen.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct(3,4); //new sizde structtırlar çalışırlar 
            
            //Dikdörtgen_Struct dikdörtgen_Struct;
            //dikdörtgen_Struct.KisaKenar = 3;
            //dikdörtgen_Struct.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı : {0}", dikdörtgen_Struct.AlanHesapla());


            Console.ReadKey();
        }
        class Dikdortgen 
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdortgen()
            {
                KisaKenar = 3;
                UzunKenar =4;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }

        }
        struct Dikdörtgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdörtgen_Struct(int kisaKenar, int uzunKenar)
            {
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }

        }
    }
}
