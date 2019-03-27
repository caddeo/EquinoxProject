namespace Equinox.Domain.Core.Events
{
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }

    public interface IHandler<in TRequest, TResponse> where TRequest : Request<TResponse>
    {
        TResponse Handle(TRequest request);
    }
}