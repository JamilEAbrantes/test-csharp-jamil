using MediatR;
using System.Threading.Tasks;

namespace Candidate.Infra.CrossCutting.Bus
{
    public class InMemoryBus : IBus
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public Task SendCommand<T>(ICommand<T> command)
        {
            return _mediator.Send(command);
        }

        public Task RaiseEvent(IEvent @event)
        {
            return _mediator.Publish(@event);
        }
    }
}