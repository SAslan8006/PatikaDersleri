using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {

            //Business kodlar
            if (product.ProductName.Length <= 2)
            {
                //Magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }
           
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product rental)
        {
            _productDal.Delete(rental);
            return new SuccessResult(Messages.ProductDelete);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.BrandCategoryId== id),Messages.Listed);
        }

        public IDataResult<List<Product>> GetAllById(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CarId == id), Messages.ProductListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitsPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min));

        }
       
        public IDataResult<List<ProductDetailDto>> GetProductDetailById(int productId)
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(c => c.ProductId == productId), Messages.Listed);

        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());

        }

        public IResult Update(Product rental)
        {
            _productDal.Update(rental);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
