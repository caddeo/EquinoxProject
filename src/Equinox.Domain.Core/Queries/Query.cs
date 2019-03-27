using MediatR;
using System;

namespace Equinox.Domain.Core.Queries
{
    public class Query<TResponse> : IRequest<TResponse>
    {
        public DateTime Timestamp { get; private set; }

        public Query()
        {
            Timestamp = DateTime.Now;
        }
    }
}