using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderdal;

        public OrderManager(IOrderDal orderdal)
        {
            _orderdal = orderdal;
        }

        [CacheRemoveAspect("OrderService.Get")]
        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {
            _orderdal.Add(order);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Order order)
        {
            _orderdal.Delete(order);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour == 02)
            {
                return new ErrorDataResult<List<Order>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Order>>(_orderdal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Order>> GetAllDate(DateTime date)
        {
            return new SuccessDataResult<List<Order>>(_orderdal.GetAll(p => p.OrderDate == date), Messages.Listed);

        }

        public IDataResult<Order> GetById(int Id)
        {
            return new SuccessDataResult<Order>(_orderdal.Get(p => p.Id == Id), Messages.Listed);

        }        

        public IDataResult<List<OrderDetailDto>> GetOrderDetailCargoId(int cargoId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderdal.GetOrderDetails(c => c.CargoId == cargoId), Messages.Listed);
        }
                
        public IDataResult<List<OrderDetailDto>> GetOrderDetails()
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderdal.GetOrderDetails(), Messages.Listed);

        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetailsBookId(int bookId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderdal.GetOrderDetails(c => c.BookId == bookId), Messages.Listed);
        }

        public IDataResult<List<OrderDetailDto>> GetOrderDetailsUserId(int userId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderdal.GetOrderDetails(c => c.UserId == userId), Messages.Listed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IResult Update(Order order)
        {
            _orderdal.Update(order);
            return new SuccessResult(Messages.Updated);
        }
    }
}
