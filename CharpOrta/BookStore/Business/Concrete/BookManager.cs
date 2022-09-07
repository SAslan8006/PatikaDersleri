using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        [CacheRemoveAspect("IBookService.Get")]
        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Book>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.Listed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Book>> GetAllByName(string name)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.BookName == name), Messages.Listed);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());

        }

        public IDataResult<List<BookDetailDto>> GetBookDetailCargoId(int cargoId)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails(c => c.CargoId == cargoId), Messages.Listed);

        }              

        public IDataResult<List<BookDetailDto>> GetBookDetailsByAuthor(int AuthorId)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails(c => c.AuthorId == AuthorId), Messages.Listed);
        }

        public IDataResult<List<BookDetailDto>> GetBookDetailsByPublisher(int PublisherId)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails(c => c.AuthorId == PublisherId), Messages.Listed);
        }

        public IDataResult<Book> GetByIsbnNo(string ısbnNo)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p => p.IsbnNo == ısbnNo));
        }

        public IDataResult<List<Book>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.Price <= max && p.Price >= min));

        }
        
    }
}
