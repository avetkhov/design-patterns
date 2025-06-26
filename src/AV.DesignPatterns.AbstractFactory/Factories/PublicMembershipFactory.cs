using AV.DesignPatterns.AbstractFactory.Domain;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Factories;

public class PublicMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    
    public PublicMembershipFactory(decimal price)
    {
        _price = price;
    }
    
    public IMembership Create() => new PublicMembership(_price);
}