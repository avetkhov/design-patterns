using AV.DesignPatterns.AbstractFactory.Domain;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Factories;

public class CorporateMembershipFactory : IMembershipFactory
{
    private readonly double _price;
    
    public CorporateMembershipFactory(double price)
    {
        _price = price;
    }
    
    public IMembership CreateMembership() => new CorporateMembership(_price, "Corporate Membership");

    public ICard CreateCard() => new CorporateCard("Corporate Card");
}