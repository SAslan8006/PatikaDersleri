using Core.Entities;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Entities.Concrete
{
    //Cıplak Class Kalmamalıdır.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
