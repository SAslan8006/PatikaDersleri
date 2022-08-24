using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Car
                             join c in context.Color on p.ColorId equals c.ColorId
                             join d in context.Brands on p.BrandId equals d.BrandId
                             select new CarDetailDto
                             {                 
                                 CarId=p.CarId,
                                 CarName=p.CarName,
                                 BrandId=p.BrandId,
                                 BrandName = d.BrandName,
                                 Model = p.Model,
                                 ColorId=p.ColorId,
                                 ColorName = c.ColorName,
                                 ModelYear=p.ModelYear,
                                 DailyPrice=p.DailyPrice,
                                 Description=p.Description
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}
