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
    public class CargoManager : ICargoService
    {
        ICargoDal _cargoDal;

        public CargoManager(ICargoDal cargoDal)
        {
            _cargoDal = cargoDal;
        }

        [CacheRemoveAspect("IAuthorService.Get")]
        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Add(Cargo entiti)
        {
            _cargoDal.Add(entiti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Cargo entiti)
        {
            _cargoDal.Delete(entiti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Cargo>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Cargo>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Cargo>>(_cargoDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Cargo> GetByName(string name)
        {
            return new SuccessDataResult<Cargo>(_cargoDal.Get(p => p.CargoName == name), Messages.Listed);

        }
        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(Cargo entiti)
        {
            _cargoDal.Update(entiti);
            return new SuccessResult(Messages.Updated);
        }
    }
}
