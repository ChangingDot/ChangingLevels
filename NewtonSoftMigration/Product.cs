using Newtonsoft.Json;

namespace NewtonSoftMigration;
public class Product
{
    public string Name { get; set; }

    [JsonIgnore]
    public DateTime Expiry { get; set; }

    public string[] Sizes { get; set; }

    // Default constructor
    public Product() { }

    // JsonConstructor
    [JsonConstructor]
    public Product(string name, string[] sizes)
    {
        Name = name;
        Sizes = sizes;
    }
}