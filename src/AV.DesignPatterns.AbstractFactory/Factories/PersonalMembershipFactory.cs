using AV.DesignPatterns.AbstractFactory.Domain;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Factories;

public class PersonalMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    
    public PersonalMembershipFactory(decimal price)
    {
        _price = price;
    }
    
    public IMembership Create() => new PersonalMembership(_price);
}