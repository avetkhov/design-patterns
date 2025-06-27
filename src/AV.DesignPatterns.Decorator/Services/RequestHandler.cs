using AV.DesignPatterns.Decorator.Interfaces;

namespace AV.DesignPatterns.Decorator.Services;

public class RequestHandler : IRequestHandler
{
    public void Handle(string request)
    {
        Console.WriteLine($"{nameof(RequestHandler)} request: {request}");
    }
}