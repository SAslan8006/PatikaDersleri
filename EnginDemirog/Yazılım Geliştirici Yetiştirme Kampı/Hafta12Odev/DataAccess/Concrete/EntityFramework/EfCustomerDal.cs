using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Customers
                             join c in context.Users on p.UserId equals c.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId = p.CustomerId,
                                 CompanyName = p.CompanyName,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }

    }
}
