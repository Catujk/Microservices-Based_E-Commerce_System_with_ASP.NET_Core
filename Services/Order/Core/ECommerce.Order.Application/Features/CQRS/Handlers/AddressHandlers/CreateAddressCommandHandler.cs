﻿using ECommerce.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        
        public async Task Handle(CreateAddressCommand request)
        {
            await _repository.CreateAsync(new Address
            {
                UserID = request.UserID,
                AddressCity = request.AddressCity,
                AddressDistrict = request.AddressDistrict,
                AddressDetail = request.AddressDetail
            });
        }
    }
}
