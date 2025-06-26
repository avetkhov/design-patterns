using AV.DesignPatterns.Proxy.Dtos;
using AV.DesignPatterns.Proxy.Interfaces;

namespace AV.DesignPatterns.Proxy.Services;

public class ProxyService : IService
{
    private IDictionary<int, string> _statuses;
    private readonly Service _service;

    public ProxyService(Service service)
    {
        _service = service;
    }

    public IEnumerable<OrderDto> GetOrders() => _service.GetOrders();

    public IDictionary<int, string> GetStatuses() => _statuses ??= _service.GetStatuses();
}