using AV.DesignPatterns.Builder.Domain;

namespace AV.DesignPatterns.Builder.Builders;

public class ProductBuilder
{
    private readonly string _name;
    private readonly List<string> _components = [];

    private ProductBuilder(string name)
    {
        _name = name;
    }

    public static ProductBuilder Create(string name)
    {
        return new ProductBuilder(name);
    }

    public ProductBuilder AddComponent(string name)
    {
        _components.Add(name);
        return this;
    }

    public Product Build()
    {
        var product = new Product(_name);
        foreach (var component in _components)
        {
            product.AddComponent(component);
        }
        
        return product;
    }
}