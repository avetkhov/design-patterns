using AV.DesignPatterns.AbstractFactory.Factories;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory;

public static class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter the membership type you would like to create: ");
        Console.WriteLine("> C - Corporate Membership");
        Console.WriteLine("> P - Personal Membership");
        
        var membershipType = Console.ReadLine();
        var membershipFactory = GetFactory(membershipType);
        var membership = membershipFactory.CreateMembership();
        var card = membershipFactory.CreateCard();
        
        Console.WriteLine($"{membership.GetType().Name} price: {membership.GetPrice()}");
        Console.WriteLine($"Card type: {card.GetCardType()}");
    }

    private static IMembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "c" => new CorporateMembershipFactory(500),
            "p" => new PersonalMembershipFactory(100),
            _ => null
        };
}