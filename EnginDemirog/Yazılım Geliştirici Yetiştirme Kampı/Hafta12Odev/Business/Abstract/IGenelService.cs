using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetAllById(int id);
        IDataResult<T> GetById(int id);
        IResult Add(T rental);
        IResult Delete(T rental);
        IResult Update(T rental);

    }
}
