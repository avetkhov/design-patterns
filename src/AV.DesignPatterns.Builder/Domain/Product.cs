using System.ComponentModel;

namespace AV.DesignPatterns.Builder.Domain;

public class Product
{
    private readonly string _name;
    private readonly List<string> _components = [];

    public Product(string name)
    {
        _name = name;
    }
    
    public string GetName() => _name;
    
    public void AddComponent(string component) => _components.Add(component);
    
    public List<string> GetComponents() => _components;
}