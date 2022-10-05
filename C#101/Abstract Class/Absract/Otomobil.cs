using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class.Absract
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() 
        {
            return 4;
        }
        public virtual Renkler StandartRengiNe() 
        {
            return Renkler.Beyaz;
        }
        public abstract Marka HangiMarkaAracı();
        
    }
}
