using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILaungageService
    {
        IDataResult<List<Laungage>> GetAll();
        IDataResult<Laungage>GetByName(String name);
        IResult Add(Laungage entiti);
        IResult Delete(Laungage entiti);
        IResult Update(Laungage entiti);
    }


}
