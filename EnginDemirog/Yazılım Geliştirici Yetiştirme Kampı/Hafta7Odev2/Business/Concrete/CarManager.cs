using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _inMemoryDal;

        public CarManager(ICarDal inMemoryDal)
        {
            _inMemoryDal = inMemoryDal;
        }

        public List<Car> GetAll()
        {
            return _inMemoryDal.GetAll();

        }
    }
}
