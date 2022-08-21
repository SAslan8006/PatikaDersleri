using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService : IGenelService<Users>
    {               
        IDataResult<Users> GetByMail(string email);  
    }
}
