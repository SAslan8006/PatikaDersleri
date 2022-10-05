using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class.Absract
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaAracı()
        {
            return Marka.Honda;
        }

        public override Renkler StandartRengiNe()
        {
            return Renkler.Gri;
        }

    }
}
