using Northwind.Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
