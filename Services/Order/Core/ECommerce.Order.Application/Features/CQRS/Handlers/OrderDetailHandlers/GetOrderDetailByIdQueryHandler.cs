using ECommerce.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
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
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery request)
        {
            var orderDetail = await _repository.GetByIdAsync(request.OrderDetailID);
            return new GetOrderDetailByIdQueryResult
            {
                OrderDetailID = orderDetail.OrderDetailID,
                ProductID = orderDetail.ProductID,
                ProductName = orderDetail.ProductName,
                ProductPrice = orderDetail.ProductPrice,
                ProductQuantity = orderDetail.ProductQuantity,
                ProductTotalPrice = orderDetail.ProductTotalPrice,
                OrderingID = orderDetail.OrderingID
            };

        }
    }
}
