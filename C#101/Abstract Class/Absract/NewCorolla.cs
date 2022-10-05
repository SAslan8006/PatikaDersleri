using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class.Absract
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaAracı()
        {
            return Marka.Toyota;
        }
    }
}
