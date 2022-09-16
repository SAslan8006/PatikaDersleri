using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IDataResult<List<Author>> GetAll();
        IDataResult<List<Author>> GetAllByName(string name);
        IResult Add(Author entiti);
        IResult Delete(Author entiti);
        IResult Update(Author entiti);

    }
}
