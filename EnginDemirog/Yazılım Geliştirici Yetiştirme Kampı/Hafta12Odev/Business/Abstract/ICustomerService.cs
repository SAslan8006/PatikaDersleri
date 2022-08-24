using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService : IService<Customer>
    {
        IDataResult<List<CustomerDetailDto>> GetCustomersDetailById(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomersDetails();

    }
}
