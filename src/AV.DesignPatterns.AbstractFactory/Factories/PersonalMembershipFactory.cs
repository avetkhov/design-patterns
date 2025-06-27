using AV.DesignPatterns.AbstractFactory.Domain;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Factories;

public class PersonalMembershipFactory : IMembershipFactory
{
    private readonly double _price;
    
    public PersonalMembershipFactory(double price)
    {
        _price = price;
    }
    
    public IMembership CreateMembership() => new PersonalMembership(_price, "Personal Membership");
    
    public ICard CreateCard() => new PersonalCard("Personal Card");
}