using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGenelService<T>
    {
        List<T> GetAll();
        List<T> GetAllByCategoryId(int id);
        List<T> GetByUnitsPrice(decimal min, decimal max);
    }
}
