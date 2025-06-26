using AV.DesignPatterns.Proxy.Dtos;

namespace AV.DesignPatterns.Proxy.Interfaces;

public interface IService
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<OrderDto> GetOrders();
}