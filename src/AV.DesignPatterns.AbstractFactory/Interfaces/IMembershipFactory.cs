namespace AV.DesignPatterns.AbstractFactory.Interfaces;

public interface IMembershipFactory
{
    IMembership CreateMembership();
    ICard CreateCard();
}