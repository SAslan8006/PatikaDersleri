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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color rental)
        {
            _colorDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color rental)
        {
            _colorDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Added);

        }

        public IDataResult<List<Color>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id), Messages.Listed);

        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == id), Messages.Listed);

        }

        public IResult Update(Color rental)
        {
            _colorDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
