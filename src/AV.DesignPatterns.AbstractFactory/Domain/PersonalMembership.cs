using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Domain;

public class PersonalMembership :  IMembership
{
    private readonly double _price;
    private readonly string _name;

    public PersonalMembership(double price, string name)
    {
        _price = price;
        _name = name;
    }
    
    public string GetName() => _name;

    public double GetPrice() => _price;
}