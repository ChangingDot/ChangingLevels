namespace NewtonSoftMigration;
public class Product
{
    public required string Name { get; set; }
    public DateTime Expiry { get; set; }
    public required string[] Sizes { get; set; }
}

