using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCargoDal : EfEntityRepositoryBase<Cargo, BookDbContext>, ICargoDal
    {

    }

    
}
