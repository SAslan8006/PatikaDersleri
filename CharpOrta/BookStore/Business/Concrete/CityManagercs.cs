using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManagercs : ICityService
    {
        ICityDal _cityDal;

        public CityManagercs(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        [CacheRemoveAspect("ICityService.Get")]
        [ValidationAspect(typeof(CityValidator))]
        public IResult Add(City entiti)
        {
            _cityDal.Add(entiti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(City entiti)
        {
            _cityDal.Delete(entiti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<City>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<City>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), Messages.Listed);
        }

        public IDataResult<City> GetByName(string name)
        {
            return new SuccessDataResult<City>(_cityDal.Get(p => p.CityName == name), Messages.Listed);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(City entiti)
        {
            _cityDal.Update(entiti);
            return new SuccessResult(Messages.Updated);
        }
    }
}
