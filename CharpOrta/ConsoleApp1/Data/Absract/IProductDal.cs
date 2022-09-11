using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Absract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
