using ECommerce.Order.Application.Features.CQRS.Results.OrderDetailResults;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var orderDetails = await _repository.GetAllAsync();
            return orderDetails.Select(orderDetail => new GetOrderDetailQueryResult
            {
                OrderDetailID = orderDetail.OrderDetailID,
                ProductID = orderDetail.ProductID,
                ProductName = orderDetail.ProductName,
                ProductPrice = orderDetail.ProductPrice,
                ProductQuantity = orderDetail.ProductQuantity,
                ProductTotalPrice = orderDetail.ProductTotalPrice,
                OrderingID = orderDetail.OrderingID,
            }).ToList();
        }
    }
}
