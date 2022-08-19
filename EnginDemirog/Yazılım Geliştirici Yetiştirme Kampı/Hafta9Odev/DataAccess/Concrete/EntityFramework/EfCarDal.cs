using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Car
                             join c in context.Color on p.ColorId equals c.ColorId
                             join d in context.BrandCategory on p.BrandId equals d.BrandCategoryId
                             select new CarDetailDto
                             {                 
                                 CarId=p.CarId,
                                 BrandCategoryName = d.BrandCategoryName,
                                 Model = p.Model,
                                 ColorName = c.ColorName,
                                 ModelYear=p.ModelYear,
                                 DailyPrice=p.DailyPrice,
                                 Description=p.Description
                             };
                return result.ToList();

            }
        }
    }
}
