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
    public class EfProductDal : EfEntityRepositoryBase<Product, CarDbContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Product
                             join c in context.Car on p.CarId equals c.CarId
                             join e in context.Color on c.ColorId equals e.ColorId
                             join d in context.BrandCategory on c.BrandId equals d.BrandCategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,                                
                                 CarId = p.CarId,
                                 BrandCategoryName = d.BrandCategoryName,
                                 Model = c.Model,
                                 ColorName = e.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description                                  
        
                             };
                return result.ToList();
                
            }
        }
    }
}
