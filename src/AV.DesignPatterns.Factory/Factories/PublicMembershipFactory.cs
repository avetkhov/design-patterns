using AV.DesignPatterns.Factory.Domain;
using AV.DesignPatterns.Factory.Interfaces;

namespace AV.DesignPatterns.Factory.Factories;

public class PublicMembershipFactory : IMembershipFactory
{
    private readonly decimal _price;
    
    public PublicMembershipFactory(decimal price)
    {
        _price = price;
    }
    
    public IMembership Create() => new PublicMembership(_price);
}