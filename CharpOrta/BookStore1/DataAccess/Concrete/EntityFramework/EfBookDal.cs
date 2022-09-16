using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookDbContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails(Expression<Func<BookDetailDto, bool>> filter = null)
        {
            using (BookDbContext context = new BookDbContext())
            {
                var result = from p in context.Books
                             join c in context.Authors on p.AuthorId equals c.Id
                             join d in context.Publishers on p.PublisherId equals d.Id
                             join e in context.Cargos on p.CargoId equals e.Id
                             join f in context.BookLaungages on p.BookLanguageId equals f.Id

                             select new BookDetailDto
                             {
                                Id=p.Id,
                                BookName=p.BookName,
                                AuthorName=c.AuthorLastName +" "+c.AuthorLastName,
                                PublisherName=d.PublisherName,
                                PageNumber=p.PageNumber,
                                Price=p.Price,
                                IsbnNo=p.IsbnNo,
                                About=p.About,
                                Stock=p.Stock,
                                CargoName=e.CargoName,
                                BookLaungage=f.BookLaungage,
                                BookImages = (from i in context.BookImages
                                              where p.Id == i.Id
                                              select new BookImage { Id = i.Id, BookId = i.Id, ImagePath = i.ImagePath, Date = i.Date }).ToList()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
