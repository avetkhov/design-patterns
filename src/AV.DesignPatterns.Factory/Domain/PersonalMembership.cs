using AV.DesignPatterns.Factory.Interfaces;

namespace AV.DesignPatterns.Factory.Domain;

public class PersonalMembership : IMembership
{
    private readonly decimal _price;

    public PersonalMembership(decimal price)
    {
        _price = price;
    }
    
    public decimal GetPrice() => _price;
}