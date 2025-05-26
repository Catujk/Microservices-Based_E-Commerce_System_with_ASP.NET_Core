using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.Mediator.Commands.OrderingCommands
{
    public class CreateOrderingCommand : IRequest
    {
        public string UserID { get; set; }
        public decimal OrderingTotalPrice { get; set; }
        public DateTime OrderingDate { get; set; }

    }
}
