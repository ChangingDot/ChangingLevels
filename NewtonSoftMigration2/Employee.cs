using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace NewtonSoftMigration2;

public class Employee
{
    [JsonProperty("employee_id")]
    public int Id { get; set; }

    [JsonRequired]
    public string Name { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public Department Department { get; set; }

    [JsonIgnore]
    public string InternalNotes { get; set; }

    [JsonExtensionData]
    public IDictionary<string, JToken> AdditionalData { get; set; }

    public DateTime? StartDate { get; set; }
}

public enum Department
{
    IT,
    HR,
    Sales
}