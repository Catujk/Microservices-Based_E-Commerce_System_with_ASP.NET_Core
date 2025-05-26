using ECommerce.Order.Application.Features.Mediator.Results.OrderingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int OrderingID { get; set; }
        public GetOrderingByIdQuery(int orderingID)
        {
            OrderingID = orderingID;
        }

    }
}
