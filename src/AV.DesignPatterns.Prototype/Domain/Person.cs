namespace AV.DesignPatterns.Prototype.Domain;

public class Person
{
    public string Name { get; init; }
    public Address Address { get; init; }

    public override string ToString() => $"Name: {Name}, City: {Address.City}, Street: {Address.Street}, Suite: {Address.Suite}";
}