using AV.DesignPatterns.Decorator.Interfaces;

namespace AV.DesignPatterns.Decorator.Services;

public abstract class RequestHandlerAbstractDecorator : IRequestHandler
{
    private readonly IRequestHandler _requestHandler;

    protected RequestHandlerAbstractDecorator(IRequestHandler requestHandler)
    {
        _requestHandler =  requestHandler;
    }

    public virtual void Handle(string request) { }
}