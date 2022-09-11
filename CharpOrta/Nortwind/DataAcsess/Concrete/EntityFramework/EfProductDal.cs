using Core.DataAccess.EntityFramework;
using DataAcsess.Absract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcsess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NortwindContext context = new NortwindContext())
            {

                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                             };
                return result.ToList();
            }
        }
    }
}
