using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookImageService
    {
        IResult Add(BookImage bookImage, IFormFile formFile);
        IResult Update(BookImage bookImage, IFormFile formFile);
        IResult Delete(BookImage bookImage);
        IDataResult<List<BookImage>> GetAll();
        IDataResult<BookImage> GetById(int id);
        IDataResult<List<BookImage>> GetByBookId(int bookId);
    }
}
