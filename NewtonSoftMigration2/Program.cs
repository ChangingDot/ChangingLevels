using Newtonsoft.Json;

namespace NewtonSoftMigration2;
public class Program
{
    public static void Main()
    {
        Employee employee = new Employee
        {
            Id = 123,
            Name = "John Doe",
            Department = Department.IT,
            InternalNotes = "This should not appear in JSON",
            StartDate = null
        };

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
            Formatting = Formatting.Indented
        };

        string json = JsonConvert.SerializeObject(employee, settings);
        Console.WriteLine(json);

        // Example of deserialization with missing required field
        string jsonInput = "{\"employee_id\": 456, \"Department\": \"Sales\"}";
        try
        {
            Employee deserializedEmployee = JsonConvert.DeserializeObject<Employee>(jsonInput, settings);
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("Deserialization error: " + ex.Message);
        }
    }
    // Expected
    // {
    //   "employee_id": 123,
    //   "Name": "John Doe"
    // }
    // Deserialization error: Required property 'Name' not found in JSON. Path '', line 1, position 43.
}