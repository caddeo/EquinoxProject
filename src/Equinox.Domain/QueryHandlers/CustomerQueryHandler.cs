using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Commands;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using MediatR;

namespace Equinox.Domain.QueryHandlers
{
    public class CustomerQueryHandler : QueryHandler,
    IRequestHandler<GetCustomerByIdQuery, Customer>
    {

        private readonly ICustomerRepository _customerRepository;
        private readonly IMediatorHandler _bus;

        public CustomerQueryHandler(ICustomerRepository customerRepository,
            IMediatorHandler bus,
            INotificationHandler<DomainNotification> notifications) : base(bus, notifications)
        {
            _customerRepository = customerRepository;
            _bus = bus;
        }

        public Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = _customerRepository.GetById(request.Id);
            return Task.FromResult(customer);
        }
    }
}