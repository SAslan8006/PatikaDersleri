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
        public IResult Add(Users rental)
        {
            _userDal.Add(rental);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Users rental)
        {
            _userDal.Delete(rental);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }

        public IDataResult<List<Users>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(x=>x.UserId== id));
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u => u.UserId == id));

        }

        public IDataResult<Users> GetByMail(string email)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u => u.Email == email));
        }

        public IResult Update(Users rental)
        {
            _userDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
