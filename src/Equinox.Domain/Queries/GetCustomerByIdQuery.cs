using System;

namespace Equinox.Domain.Commands
{
    public class GetCustomerByIdQuery : CustomerQuery
    {
        public GetCustomerByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}