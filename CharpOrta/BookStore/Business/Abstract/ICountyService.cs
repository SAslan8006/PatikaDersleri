using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICountyService
    {
        IDataResult<List<County>> GetAll();
        IDataResult<List<County>> GetAllById(int CityId);
        IDataResult<County> GetById(int id);
        IResult Add(County entiti);
        IResult Delete(County entiti);
        IResult Update(County entiti);

    }
}
