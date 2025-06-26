using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Domain;

public class PersonalMembership : IMembership
{
    private readonly decimal _price;

    public PersonalMembership(decimal price)
    {
        _price = price;
    }
    
    public decimal GetPrice() => _price;
}