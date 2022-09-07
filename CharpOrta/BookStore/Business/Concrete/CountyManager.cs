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
    public class CountyManager : ICountyService
    {
        ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;
        }

        [CacheRemoveAspect("ICountyService.Get")]
        [ValidationAspect(typeof(CountyValidator))]
        public IResult Add(County entiti)
        {
            _countyDal.Add(entiti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(County entiti)
        {
            _countyDal.Delete(entiti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<County>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<County>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<County>>(_countyDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<County>> GetAllById(int CityId)
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll(p => p.Id == CityId), Messages.Listed);

        }

        public IDataResult<County> GetById(int id)
        {
            return new SuccessDataResult<County>(_countyDal.Get(p => p.Id == id), Messages.Listed);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(County entiti)
        {
            _countyDal.Update(entiti);
            return new SuccessResult(Messages.Updated);
        }
    }
}
