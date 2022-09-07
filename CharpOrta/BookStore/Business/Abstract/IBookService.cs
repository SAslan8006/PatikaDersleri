using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService 
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByName(string name);
        IDataResult<Book> GetByIsbnNo(string ısbnNo);
        IResult Add(Book book);
        IResult Delete(Book book);
        IResult Update(Book book);
        IDataResult<List<BookDetailDto>> GetBookDetails();
        IDataResult<List<Book>> GetByPrice(decimal min, decimal max);
        IDataResult<List<BookDetailDto>> GetBookDetailsByAuthor(int AuthorId);
        IDataResult<List<BookDetailDto>> GetBookDetailsByPublisher(int PublisherId);
        IDataResult<List<BookDetailDto>> GetBookDetailCargoId(int cargoId);


    }
}
