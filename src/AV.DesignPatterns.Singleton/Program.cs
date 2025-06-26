using AV.DesignPatterns.Singleton.Services;

namespace AV.DesignPatterns.Singleton;

public static class Program
{
    private static void Main()
    {
        var service1 = SingletonService.Instance;
        var service2 = SingletonService.Instance;

        service1.RetrieveHashCode();
        service2.RetrieveHashCode();
    }
}