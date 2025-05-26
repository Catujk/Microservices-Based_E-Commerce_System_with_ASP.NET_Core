using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Order.Application.Features.CQRS.Commands.AddressCommands
{
    public class DeleteAddressCommand
    {
        public int AddressID { get; set; }
        public DeleteAddressCommand(int addressID)
        {
            AddressID = addressID;
            
        }
    }
}
