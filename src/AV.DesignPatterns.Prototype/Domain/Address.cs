namespace AV.DesignPatterns.Prototype.Domain;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int Suite { get; set; }
    
    public Address Clone()
    {
        return new  Address { City = City, Street = Street, Suite = Suite };
    }
}