using AV.DesignPatterns.Decorator.Services;

namespace AV.DesignPatterns.Decorator;

public static class Program
{
    public static void Main()
    {
        var handler = new RequestHandler();
        handler.Handle("Request to handler");
        
        var decorator = new Services.RequestHandlerDecorator(handler);
        decorator.Handle("Request to decorator");
    }
}