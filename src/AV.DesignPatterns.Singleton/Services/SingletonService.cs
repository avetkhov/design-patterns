namespace AV.DesignPatterns.Singleton.Services;

public sealed class SingletonService
{
    private static readonly Lazy<SingletonService> LazyInstance = new Lazy<SingletonService>(() => new SingletonService());

    private SingletonService()
    {
    }
    
    public static SingletonService Instance => LazyInstance.Value;

    public void RetrieveHashCode() => Console.WriteLine($"{LazyInstance.GetHashCode()}");
}