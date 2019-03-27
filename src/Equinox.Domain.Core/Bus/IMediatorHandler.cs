using System.Threading.Tasks;
using Equinox.Domain.Core.Commands;
using Equinox.Domain.Core.Events;
using Equinox.Domain.Core.Queries;


namespace Equinox.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task<TResponse> GetQuery<TResponse, TQuery>(TQuery query) where TQuery : Query<TResponse>;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
