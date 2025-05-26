using ECommerce.Order.Application.Features.CQRS.Queries.AddressQueries;
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
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery request)
        {
            var address = await _repository.GetByIdAsync(request.AddressID);
            return new GetAddressByIdQueryResult
            {
                AddressID = address.AddressID,
                UserID = address.UserID,
                AddressCity = address.AddressCity,
                AddressDistrict = address.AddressDistrict,
                AddressDetail = address.AddressDetail
            };
        }
    }
}
