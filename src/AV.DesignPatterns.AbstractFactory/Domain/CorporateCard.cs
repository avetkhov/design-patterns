using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Domain;

public class CorporateCard : ICard
{
    private readonly string _type;

    public CorporateCard(string type)
    {
        _type = type;
    }

    public string GetCardType() => _type;
}