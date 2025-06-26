using AV.DesignPatterns.Proxy.Dtos;
using AV.DesignPatterns.Proxy.Interfaces;

namespace AV.DesignPatterns.Proxy.Services;

public class Service : IService
{
    public IEnumerable<OrderDto> GetOrders()
    {
        var orders = new List<OrderDto>
        {
            new() { Name = "Burger", StatusId = RandomizeStatus() },
            new() { Name = "Pasta", StatusId = RandomizeStatus() },
            new() { Name = "Omelet", StatusId = RandomizeStatus() },
        };

        return orders;
    }

    public IDictionary<int, string> GetStatuses()
    {
        var statuses = new Dictionary<int, string>
        {
            { 1, "not ready" },
            { 2, "preparing" },
            { 3, "ready" }
        };

        Thread.Sleep(5000);

        return statuses;
    }

    private static int RandomizeStatus() => new Random().Next(1, 4);
}