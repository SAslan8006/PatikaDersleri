using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> GetByName(string name);
        IResult Add(City entiti);
        IResult Delete(City entiti);
        IResult Update(City entiti);
    }
}
