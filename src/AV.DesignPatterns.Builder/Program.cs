using AV.DesignPatterns.Builder.Builders;

namespace AV.DesignPatterns.Builder;

public static class Program
{
    public static void Main()
    {
        var product = ProductBuilder
            .Create("Car")
            .AddComponent("Wheel")
            .AddComponent("Door")
            .Build();
        
        Console.WriteLine(product.GetName());
        foreach (var component in product.GetComponents())
        {
            Console.WriteLine(component);
        }
    }
}