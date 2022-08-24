using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IService<Rental>
    {
        IDataResult<List<Rental>> GetByAmountPrice(decimal min, decimal max);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsById(int id);
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByUserId(int userId);
        IDataResult<List<RentalDetailDto>> GetRentalDetailByCarId(int userId);
        IDataResult<List<Rental>> GetByCarId(int id);
        
    }
}
