using ECommerce.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using ECommerce.Order.Application.Features.CQRS.Queries.AddressQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Order.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly GetAddressQueryHandler _getAddressQueryHandler;
        private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
        private readonly CreateAddressCommandHandler _createAddressCommandHandler;
        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
        private readonly DeleteAddressCommandHandler _deleteAddressCommandHandler;

        public AdressesController(GetAddressQueryHandler getAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, DeleteAddressCommandHandler deleteAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler)
        {
            _getAddressQueryHandler = getAddressQueryHandler;
            _getAddressByIdQueryHandler = getAddressByIdQueryHandler;
            _createAddressCommandHandler = createAddressCommandHandler;
            _deleteAddressCommandHandler = deleteAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var results = await _getAddressQueryHandler.Handle();
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> AddressById(int id)
        {
            var result = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
        {
            await _createAddressCommandHandler.Handle(command);
            return Ok("Address added.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
        {
            await _updateAddressCommandHandler.Handle(command);
            return Ok("Address updated.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            await _deleteAddressCommandHandler.Handle(new DeleteAddressCommand(id));
            return Ok("Address deleted.");
        }
    }
}
