using Newtonsoft.Json;

namespace NewtonSoftMigration;
public class JsonSerializer
{
    public static string SerializeObject<T>(T objectToSerialize)
    {
        return JsonConvert.SerializeObject(objectToSerialize);
    }

    public static T DeserializeObject<T>(string jsonString)
    {
#pragma warning disable CS8603 // Possible null reference return.
        return JsonConvert.DeserializeObject<T>(jsonString);
    }
}
