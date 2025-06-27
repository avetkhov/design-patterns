using AV.DesignPatterns.Decorator.Interfaces;

namespace AV.DesignPatterns.Decorator.Services;

public class RequestHandlerDecorator : RequestHandlerAbstractDecorator
{
    public RequestHandlerDecorator(IRequestHandler requestHandler)
        : base(requestHandler)
    {
    }

    public override void Handle(string request)
    {
        Console.WriteLine($"{nameof(RequestHandlerDecorator)} request: {request}");
    }
}