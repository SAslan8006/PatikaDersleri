using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Arayüzler_
{
    public class DataBaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Datebase e log yazar.");
        }
    }
}
