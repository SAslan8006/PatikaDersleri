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
        public List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Product
                             join c in context.Car on p.CarId equals c.CarId
                             join e in context.Color on c.ColorId equals e.ColorId
                             join d in context.Brands on c.BrandId equals d.BrandId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,                              
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,                                
                                 CarId = p.CarId,
                                 CarName=c.CarName,
                                 BrandName = d.BrandName,
                                 Model = c.Model,
                                 ColorName = e.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description                                  
        
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}
