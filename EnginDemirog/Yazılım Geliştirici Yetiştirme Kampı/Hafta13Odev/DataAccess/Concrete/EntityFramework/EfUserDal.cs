﻿using Core.Entities.Concrete;
using Core.Entities.EntityFramework;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
