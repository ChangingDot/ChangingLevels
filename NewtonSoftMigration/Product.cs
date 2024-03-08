using Newtonsoft.Json;

namespace NewtonSoftMigration;
public class Product
{
    public string Name { get; set; }

    [JsonIgnore]
    public DateTime Expiry { get; set; }

    public string[] Sizes { get; set; }

    // Default constructor
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Product() { }

    // JsonConstructor
    [JsonConstructor]
    public Product(string name, string[] sizes)
    {
        Name = name;
        Sizes = sizes;
    }
}