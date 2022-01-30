using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TranferCommandHandler : IRequestHandler<CreateTranferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TranferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTranferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TranferCreateEvent(request.From, request.To, request.Ammount));
            return Task.FromResult(true);
        }
    }
}
