using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Car  on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId                          
                             join cl in context.Color
                             on c.ColorId equals cl.ColorId
                             join u in context.Users
                             on r.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = cl.ColorId,
                                 ColorName = cl.ColorName,
                                 ModelName = c.Model,
                                 RentalId = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 Amount = r.Amount,
                                 UserId = u.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
