using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaAracı()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renkler StandartRengiNe()
        {
            return Renkler.Beyaz;
        }
    }
}
