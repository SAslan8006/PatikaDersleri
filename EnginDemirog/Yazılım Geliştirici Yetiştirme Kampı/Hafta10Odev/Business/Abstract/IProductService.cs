using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService:IGenelService<Product>
    {
        IDataResult<List<Product>> GetByUnitsPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
