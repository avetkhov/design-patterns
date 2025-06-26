using AV.DesignPatterns.Factory.Interfaces;

namespace AV.DesignPatterns.Factory.Domain;

public class PublicMembership : IMembership
{
    private readonly decimal _price;
    
    public PublicMembership(decimal price)
    {
        _price = price;
    }
    
    public decimal GetPrice() => _price;
}