using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using MediatR;

namespace Equinox.Domain.QueryHandlers
{
    public class QueryHandler
    {
        private readonly IMediatorHandler _bus;
        private readonly DomainNotificationHandler _notifications;

        public QueryHandler(IMediatorHandler bus, INotificationHandler<DomainNotification> notifications)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _bus = bus;
        }
    }
}