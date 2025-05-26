using ECommerce.Order.Application.Features.CQRS.Results.AddressResults;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var addresses = await _repository.GetAllAsync();
            return addresses.Select(address => new GetAddressQueryResult
            {
                AddressID = address.AddressID,
                UserID = address.UserID,
                AddressCity = address.AddressCity,
                AddressDistrict = address.AddressDistrict,
                AddressDetail = address.AddressDetail
            }).ToList();
        }
    }
}
