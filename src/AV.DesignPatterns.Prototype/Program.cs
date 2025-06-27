using AV.DesignPatterns.Prototype.Domain;

namespace AV.DesignPatterns.Prototype;

public static class Program
{
    public static void Main()
    {
        var address = new Address { City = "Lisbon", Street = "Main Street" };
        
        var john = new Person
        {
            Name = "John",
            Address = address.Clone()
        };
        john.Address.Suite = 100;
        
        var jane = new Person
        {
            Name = "Jane",
            Address = address.Clone()
        };
        jane.Address.Suite = 200;
        
        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}