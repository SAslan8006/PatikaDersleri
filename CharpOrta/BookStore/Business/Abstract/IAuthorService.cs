using Business.ValidationRules.FluentValidation;
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
        IDataResult<Author> GetByName(String name);
        IResult Add(Author entiti);
        IResult Delete(Author entiti);
        IResult Update(Author entiti);
    }
}
