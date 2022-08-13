using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - Syntax
        public void Add(Product product) 
        {
            Console.WriteLine($"{product.ProductName} Sepete eklendi.");
        }
    }
}
