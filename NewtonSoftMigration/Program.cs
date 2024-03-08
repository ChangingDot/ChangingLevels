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
        Console.WriteLine("Deserialized Product:");
        Console.WriteLine($"Name: {deserializedProduct.Name}");
        Console.WriteLine($"Expiry: {deserializedProduct.Expiry.ToShortDateString()}");
        Console.WriteLine($"Sizes: {string.Join(", ", deserializedProduct.Sizes)}");
        // Expected
        // Serialized JSON:
        // {"Name":"Apple","Sizes":["Small"]}
        // Deserialized Product:
        // Name: Apple
        // Expiry: 1/1/0001
        // Sizes: Small
    }
}