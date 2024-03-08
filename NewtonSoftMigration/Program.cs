namespace NewtonSoftMigration;
public class Program
{
    public static void Main()
    {
        Product product = new Product
        {
            Name = "Apple",
            Expiry = new DateTime(2008, 12, 28),
            Sizes = new string[] { "Small" }
        };

        // Serialize the product object to JSON
        string json = JsonSerializer.SerializeObject(product);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        // Deserialize the JSON back to a Product object
        Product deserializedProduct = JsonSerializer.DeserializeObject<Product>(json);
        Console.WriteLine("\nDeserialized Product:");
        Console.WriteLine($"Name: {deserializedProduct.Name}");
        Console.WriteLine($"Expiry: {deserializedProduct.Expiry.ToShortDateString()}");
        Console.WriteLine($"Sizes: {string.Join(", ", deserializedProduct.Sizes)}");
    }
}