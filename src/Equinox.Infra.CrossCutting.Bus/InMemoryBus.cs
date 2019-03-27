using System.Threading.Tasks;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Commands;
using Equinox.Domain.Core.Events;
using Equinox.Domain.Core.Queries;
using MediatR;

namespace Equinox.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IEventStore _eventStore;

        public InMemoryBus(IEventStore eventStore, IMediator mediator)
        {
            _eventStore = eventStore;
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public Task<TResponse> GetQuery<TResponse, TQuery>(TQuery query) where TQuery : Query<TResponse>
        {
            return _mediator.Send(query);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
                _eventStore?.Save(@event);

            return _mediator.Publish(@event);
        }
    }
}