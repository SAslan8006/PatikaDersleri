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
    public class LaungageManager : ILaungageService
    {
        ILaungageDal _laungageDal;

        public LaungageManager(ILaungageDal laungageDal)
        {
            _laungageDal = laungageDal;
        }

        [CacheRemoveAspect("LaungageService.Get")]
        [ValidationAspect(typeof(LaungageValidator))]
        public IResult Add(Laungage entiti)
        {
            _laungageDal.Add(entiti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Laungage entiti)
        {
            _laungageDal.Delete(entiti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Laungage>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Laungage>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Laungage>>(_laungageDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Laungage> GetByName(string name)
        {
            return new SuccessDataResult<Laungage>(_laungageDal.Get(p => p.BookLaungage== name), Messages.Listed);

        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(Laungage entiti)
        {
            _laungageDal.Update(entiti);
            return new SuccessResult(Messages.Updated);
        }
    }
}
