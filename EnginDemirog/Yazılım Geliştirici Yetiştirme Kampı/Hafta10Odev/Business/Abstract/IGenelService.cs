using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGenelService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetAllByCategoryId(int id);
        IDataResult<List<T>> GetByUnitsPrice(decimal min, decimal max);
        IDataResult<T> GetById(int id);
        IResult Add(T product);        
        
    }
}
