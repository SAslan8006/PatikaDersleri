using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService:IService<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetByUnitsPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarDetailsByBrand(int brandId);
        IDataResult<List<Car>> GetCarDetailsByColor(int colorId);
    }
}
