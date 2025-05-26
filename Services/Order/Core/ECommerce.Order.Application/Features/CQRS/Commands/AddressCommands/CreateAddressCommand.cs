using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class CreateAddressCommand
    {
        public string UserID { get; set; }
        public string AddressCity { get; set; }
        public string AddressDistrict { get; set; }
        public string AddressDetail { get; set; }
    }
}
