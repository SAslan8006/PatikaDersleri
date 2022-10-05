using Abstract_Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class.Absract
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaAracı()
        {
            return Marka.Ford;
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
