using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
