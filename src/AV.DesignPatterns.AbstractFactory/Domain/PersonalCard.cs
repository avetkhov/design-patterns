using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory.Domain;

public class PersonalCard : ICard
{
    private readonly string _type;

    public PersonalCard(string type)
    {
        _type = type;
    }

    public string GetCardType() => _type;
}