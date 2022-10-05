using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaAracı()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renkler StandartRengiNe()
        {
            return Renkler.Gri;
        }
    }
}
