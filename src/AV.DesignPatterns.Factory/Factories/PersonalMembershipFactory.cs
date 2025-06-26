using AV.DesignPatterns.Factory.Domain;
using AV.DesignPatterns.Factory.Interfaces;

namespace AV.DesignPatterns.Factory.Factories;

public class PersonalMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    
    public PersonalMembershipFactory(decimal price)
    {
        _price = price;
    }
    
    public IMembership Create() => new PersonalMembership(_price);
}