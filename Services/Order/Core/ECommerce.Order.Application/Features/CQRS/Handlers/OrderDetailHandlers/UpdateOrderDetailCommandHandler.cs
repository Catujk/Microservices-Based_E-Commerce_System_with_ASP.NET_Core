using ECommerce.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOrderDetailCommand request)
        {
            var orderDetail = await _repository.GetByIdAsync(request.OrderDetailID);
            orderDetail.ProductID = request.ProductID;
            orderDetail.ProductName = request.ProductName;
            orderDetail.ProductPrice = request.ProductPrice;
            orderDetail.ProductQuantity = request.ProductQuantity;
            orderDetail.ProductTotalPrice = request.ProductTotalPrice;
            orderDetail.OrderingID = request.OrderingID;
            await _repository.UpdateAsync(orderDetail);
        }
    }
}
