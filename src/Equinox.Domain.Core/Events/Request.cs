using MediatR;
using System;

namespace Equinox.Domain.Core.Events
{
    public class Request<TResponse> : IRequest<TResponse>
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Request()
        {
            MessageType = typeof(TResponse).Name;
        }
    }
}