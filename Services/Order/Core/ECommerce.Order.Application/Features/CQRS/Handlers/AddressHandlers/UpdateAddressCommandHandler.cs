using ECommerce.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAddressCommand request)
        {
            var address = await _repository.GetByIdAsync(request.AddressID);
            address.UserID = request.UserID;
            address.AddressCity = request.AddressCity;
            address.AddressDistrict = request.AddressDistrict;
            address.AddressDetail = request.AddressDetail;
            await _repository.UpdateAsync(address);
        }
    }
}
