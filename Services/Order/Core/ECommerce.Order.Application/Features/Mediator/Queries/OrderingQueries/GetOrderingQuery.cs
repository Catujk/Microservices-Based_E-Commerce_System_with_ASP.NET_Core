﻿using ECommerce.Order.Application.Features.Mediator.Results.OrderingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; }
        public decimal OrderingTotalPrice { get; set; }
        public DateTime OrderingDate { get; set; }

    }
}
