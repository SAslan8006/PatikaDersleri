using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customers, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in context.Customers
                             join c in context.Users on p.UserId equals c.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId = p.CustomersId,
                                 CompanyName = p.CompanyName,
                                 FirstName = c.FirstName,
                                 LastName = c.LastName
                             };
                return result.ToList();

            }
        }

    }
}
