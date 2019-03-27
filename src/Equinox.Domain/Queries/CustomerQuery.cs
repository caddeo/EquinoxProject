using System;
using Equinox.Domain.Core.Queries;
using Equinox.Domain.Models;

namespace Equinox.Domain.Commands
{
    public class CustomerQuery : Query<Customer>
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }
    }
}