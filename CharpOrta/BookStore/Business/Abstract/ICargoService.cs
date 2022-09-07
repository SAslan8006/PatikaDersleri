using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICargoService
    {
        IDataResult<List<Cargo>> GetAll();
        IDataResult<Cargo>GetByName(string name);
        IResult Add(Cargo entiti);
        IResult Delete(Cargo entiti);
        IResult Update(Cargo entiti);
    }
}
