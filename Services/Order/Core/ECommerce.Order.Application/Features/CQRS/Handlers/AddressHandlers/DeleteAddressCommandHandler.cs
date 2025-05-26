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
    public class DeleteAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public DeleteAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteAddressCommand request)
        {
            var address = await _repository.GetByIdAsync(request.AddressID);

            await _repository.DeleteAsync(address);

        }
    }
}
