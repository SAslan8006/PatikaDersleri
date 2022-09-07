using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, BookDbContext>, IOrderDal
    {
       
        public List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (BookDbContext context = new BookDbContext())
            {
                var result = from p in context.Orders
                             join c in context.Books on p.BookId equals c.Id
                             join d in context.Publishers on c.PublisherId equals d.Id
                             join e in context.Cargos on c.CargoId equals e.Id
                             join f in context.Citys on p.CityId equals f.Id
                             join g in context.Counties on p.CountyId equals g.Id
                             join h in context.Authors on c.AuthorId equals h.Id
                             join b in context.BookLaungages on c.BookLanguageId equals b.Id
                             join k in context.Users on p.UserId equals k.Id

                             select new OrderDetailDto
                             { 
                                 UserId=p.UserId,
                                 BookId=p.BookId,
                                 BookName=c.BookName,
                                 AuthorId = c.AuthorId,
                                 AuthorName = h.AuthorLastName + " " + h.AuthorLastName,
                                 PublisherId=c.PublisherId,
                                 PublisherName = d.PublisherName, 
                                 PageNumber = c.PageNumber,
                                 Price = c.Price,
                                 IsbnNo = c.IsbnNo,
                                 About = c.About,
                                 Stock = c.Stock,
                                 CargoId = c.CargoId,
                                 CargoName = e.CargoName,
                                 BookLanguageId = c.BookLanguageId,
                                 BookLaungage = b.BookLaungage,
                                 FirstName=k.FirstName,
                                 LastName=k.LastName
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

    }
}
