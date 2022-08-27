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
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand rental)
        {
            _brandDal.Add(rental);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand rental)
        {
            _brandDal.Delete(rental);
            return new SuccessResult(Messages.BrandDelete);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.Listed);

        }

        public IDataResult<List<Brand>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId == id), Messages.Listed);

        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id),Messages.Listed);

        }

        public IResult Update(Brand rental)
        {
            _brandDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
