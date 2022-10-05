using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1.Entities
{
    public class Category:DbContext
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
