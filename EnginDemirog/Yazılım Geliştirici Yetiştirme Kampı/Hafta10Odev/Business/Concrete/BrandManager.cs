using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandCategoryDal _brandDal;

        public BrandManager(IBrandCategoryDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brands rental)
        {
            _brandDal.Add(rental);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brands rental)
        {
            _brandDal.Delete(rental);
            return new SuccessResult(Messages.BrandDelete);
        }

        public IDataResult<List<Brands>> GetAll()
        {
            return new SuccessDataResult<List<Brands>>(_brandDal.GetAll(), Messages.Added);

        }

        public IDataResult<List<Brands>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Brands>>(_brandDal.GetAll(p => p.BrandCategoryId == id), Messages.Listed);

        }

        public IDataResult<Brands> GetById(int id)
        {
            return new SuccessDataResult<Brands>(_brandDal.Get(p => p.BrandCategoryId == id),Messages.Listed);

        }

        public IResult Update(Brands rental)
        {
            _brandDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
