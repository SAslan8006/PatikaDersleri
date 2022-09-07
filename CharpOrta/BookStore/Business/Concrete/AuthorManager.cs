using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        [CacheRemoveAspect("IAuthorService.Get")]
        [ValidationAspect(typeof(AuthorValidator))]
        public IResult Add(Author entiti)
        {
            _authorDal.Add(entiti);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Author entiti)
        {
            _authorDal.Delete(entiti);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Author>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Author>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Author>>(_authorDal.GetAll(), Messages.Listed);
        }


        public IDataResult<Author> GetByName(string name)
        {
            return new SuccessDataResult<Author>(_authorDal.Get(p => p.AuthorFirstName == name), Messages.Listed);

        }

        [CacheAspect]
        [PerformanceAspect(5)] 
        public IResult Update(Author entiti)
        {
            _authorDal.Update(entiti);
            return new SuccessResult(Messages.Updated);
        }
    }
}
