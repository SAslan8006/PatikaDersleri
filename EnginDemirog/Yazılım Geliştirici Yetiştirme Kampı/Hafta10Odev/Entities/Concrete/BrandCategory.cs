using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BrandCategory:IEntity
    {
        public int BrandCategoryId { get; set; }
        public string BrandCategoryName { get; set; }
    }
}
