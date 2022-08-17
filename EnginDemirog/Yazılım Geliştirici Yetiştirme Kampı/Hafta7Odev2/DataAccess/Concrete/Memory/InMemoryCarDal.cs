using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DataAccess.Concrete.Memory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,Model="Corsa",ColorId=1,ModelYear=2009,DailyPrice=450,Description="Yeni Temiz" },
                new Car{CarId=2,BrandId=1,Model="Corsa1",ColorId=2,ModelYear=2010,DailyPrice=300,Description="Yeni Temiz" },
                new Car{CarId=3,BrandId=2,Model="C30",ColorId=2,ModelYear=2020,DailyPrice=200 ,Description="Yeni Temiz"},
                new Car{CarId=4,BrandId=2,Model="C20",ColorId=3,ModelYear=2020,DailyPrice=1500 , Description = "Yeni Temiz"},
                new Car{CarId=5,BrandId=2,Model="C10",ColorId=4,ModelYear=2022,DailyPrice=2500 , Description = "Yeni Temiz"},

            };
        }

        public InMemoryCarDal(List<Car> cars)
        {
            _cars = cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete=_cars.SingleOrDefault(x=>x.CarId==car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllBrandCategoryId(int BrandId)
        {
           return _cars.Where(x=>x.BrandId==BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(x => x.CarId == car.CarId);            
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.Model = car.Model;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
            carUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
