using Spotify.Domain.Abstractions.Entities;

namespace Spotify.Domain.Entities;

public class Product : DomainEntity<Guid>
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
    
    public static Product Create(Guid id, string name, decimal price, string description)
    {
        return new Product(id, name, price, description);
    }

    public Product(Guid id, string name, decimal price, string description)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
    }

    public void Update(string name, decimal price, string description)
    {
        Name = name;
        Price = price;
        Description = description;
    }

    private bool NameValidation(string name)
       => name.Contains("ABCD-");

}
