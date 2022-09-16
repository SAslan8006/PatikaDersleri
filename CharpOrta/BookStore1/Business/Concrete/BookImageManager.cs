using Business.Abstract;
using Business.BusinessAspects.Autofac.Business.BusinessAspects.Autofac;
using Business.Constans;
using Core.Aspects.Caching;
using Core.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookImageManager : IBookImageService

    {
        IBookImageDal _bookImageDal;

        public BookImageManager(IBookImageDal bookImageDal)
        {
            _bookImageDal = bookImageDal;
        }

        //[SecuredOperation("book.add,admin")]
        public IResult Add(BookImage bookImage, IFormFile formFile)
        {
            var result = BusinessRules.Run(CheckBookImageCount(bookImage.BookId));
            if (result != null)
            {
                return result;
            }
            var imageResult = FileHelper.Add(formFile);
            if (!imageResult.Success)
            {
                return new ErrorResult();
            }
            bookImage.ImagePath = imageResult.Message;
            bookImage.Date = DateTime.Now;
            _bookImageDal.Add(bookImage);

            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(BookImage bookImage)
        {
            var delete = _bookImageDal.Get(c => c.BookId == bookImage.Id);
            if (bookImage == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }
            FileHelper.Delete(delete.ImagePath);
            _bookImageDal.Delete(bookImage);
            return new SuccessResult(Messages.ImageDeleted);
        }
        [CacheAspect]
        public IDataResult<List<BookImage>> GetAll()
        {
            return new SuccessDataResult<List<BookImage>>(_bookImageDal.GetAll());
        }

        [CacheAspect]
        public IDataResult<List<BookImage>> GetByBookId(int bookId)
        {
            var result = _bookImageDal.GetAll(c => c.BookId == bookId);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<BookImage>>(result);
            }
            List<BookImage> images = new List<BookImage>();
            images.Add(new BookImage() { BookId = 0, Id = 0, ImagePath = "/images/defaultt.jpg" });
            return new SuccessDataResult<List<BookImage>>(images);
        }

        public IDataResult<BookImage> GetById(int id)
        {
            return new SuccessDataResult<BookImage>(_bookImageDal.Get(c => c.BookId == id));
        }

        public IResult Update(BookImage bookImage, IFormFile formFile)
        {
            var isImage = _bookImageDal.Get(c => c.BookId == bookImage.Id);
            if (isImage == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            var updated = FileHelper.Update(isImage.ImagePath, formFile);
            if (!updated.Success)
            {
                return new ErrorResult(Messages.ImageError);
            }
            bookImage.ImagePath = (updated.Message);
            _bookImageDal.Update(bookImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        //business rules 5 den fazla resim olmayacak 
        public IResult CheckBookImageCount(int bookId)
        {
            var result = _bookImageDal.GetAll(c => c.BookId == bookId);
            if (result.Count > 5)
            {
                return new ErrorResult(Messages.BookCheckImageLimited);
            }
            return new SuccessResult();
        }
    }
}
