namespace AV.DesignPatterns.Proxy.Dtos;

public class OrderDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; init; }
    public int StatusId { get; init; }
}