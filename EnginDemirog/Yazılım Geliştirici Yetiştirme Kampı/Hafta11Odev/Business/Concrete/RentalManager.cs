using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<Rental>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.UserId == id));
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetByAmountPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.Amount <= max && p.Amount >= min));
        }

        //public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        //{
        //    return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        //}

        //public IDataResult<List<RentalDetailDto>> GetRentalDetailsById(int id)
        //{
        //    return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(r => r.CarId == id));
        //}

        //public IDataResult<List<RentalDetailDto>> GetRentalDetailsByUserId(int userId)
        //{
        //    return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(r => r.UserId == userId));
        //}

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
