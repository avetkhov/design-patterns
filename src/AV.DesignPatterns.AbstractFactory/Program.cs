using AV.DesignPatterns.AbstractFactory.Factories;
using AV.DesignPatterns.AbstractFactory.Interfaces;

namespace AV.DesignPatterns.AbstractFactory;

public static class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter the membership type you would like to create: ");
        Console.WriteLine("> P - Public");
        Console.WriteLine("> V - Personal");
        
        var membershipType = Console.ReadLine();
        var membershipFactory = GetFactory(membershipType);
        var membership = membershipFactory.Create();
        
        Console.WriteLine($"{membership.GetType().Name} price: {membership.GetPrice()}");
    }

    private static IMembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "v" => new PersonalMembershipFactory(100),
            "p" => new PublicMembershipFactory(50),
            _ => null
        };
}