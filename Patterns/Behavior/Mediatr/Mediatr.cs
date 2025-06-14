namespace Behavior.Mediatr;

public interface IRequest<TResponse> { }

public interface IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    TResponse Handle(TRequest request);
}

public class Mediator
{
    private readonly Dictionary<Type, object> _handlers = new();

    public void RegisterHandler<TRequest, TResponse>(IRequestHandler<TRequest, TResponse> handler)
        where TRequest : IRequest<TResponse>
    {
        _handlers[typeof(TRequest)] = handler;
    }

    public TResponse Send<TRequest, TResponse>(TRequest request)
        where TRequest : IRequest<TResponse>
    {
        if (_handlers.TryGetValue(typeof(TRequest), out var handlerObj))
        {
            var handler = handlerObj as IRequestHandler<TRequest, TResponse>;
            if (handler == null)
                throw new InvalidOperationException("Handler cast failed");

            return handler.Handle(request);
        }

        throw new InvalidOperationException($"No handler registered for {typeof(TRequest).Name}");
    }
}

public class GetTimeQuery : IRequest<string> { }

public class GetTimeHandler : IRequestHandler<GetTimeQuery, string>
{
    public string Handle(GetTimeQuery request)
    {
        return DateTime.Now.ToString("T");
    }
}
