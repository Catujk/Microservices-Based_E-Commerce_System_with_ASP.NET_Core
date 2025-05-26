using ECommerce.Order.Application.Features.Mediator.Commands.OrderingCommands;
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
    public class DeleteOrderingCommandHandler : IRequestHandler<DeleteOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public DeleteOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteOrderingCommand request, CancellationToken cancellationToken)
        {
            var ordering = await _repository.GetByIdAsync(request.OrderingID);
            await _repository.DeleteAsync(ordering);

        }
    }
}
