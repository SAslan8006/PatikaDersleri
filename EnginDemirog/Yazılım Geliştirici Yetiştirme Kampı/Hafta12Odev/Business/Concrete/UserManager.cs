using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User rental)
        {
            _userDal.Add(rental);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User rental)
        {
            _userDal.Delete(rental);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetAllById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(x=>x.UserId== id));
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == id));

        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IResult Update(User rental)
        {
            _userDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
