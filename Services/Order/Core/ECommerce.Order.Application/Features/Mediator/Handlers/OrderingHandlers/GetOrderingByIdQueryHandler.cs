﻿using ECommerce.Order.Application.Features.Mediator.Queries.OrderingQueries;
using ECommerce.Order.Application.Features.Mediator.Results.OrderingResults;
using ECommerce.Order.Application.Interfaces;
using ECommerce.Order.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var ordering = await _repository.GetByIdAsync(request.OrderingID);
            var result = new GetOrderingByIdQueryResult
            {
                OrderingID = ordering.OrderingID,
                UserID = ordering.UserID,
                OrderingTotalPrice = ordering.OrderingTotalPrice,
                OrderingDate = ordering.OrderingDate
            };
            return result;
        }
    }
    
}
