using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int Id);
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
        IDataResult<List<OrderDetailDto>> GetOrderDetails();
        IDataResult<List<Order>> GetByPrice(decimal min, decimal max);
        IDataResult<List<OrderDetailDto>> GetOrderDetailsUserId(int userId);
        IDataResult<List<OrderDetailDto>> GetOrderDetailsBookId(int bookId);
        IDataResult<List<OrderDetailDto>> GetOrderDetailCargoId(int cargoId);
        IDataResult<List<OrderDetailDto>> GetOrderDetailDate(DateTime date);



    }
}
