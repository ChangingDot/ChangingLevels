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
        return JsonConvert.DeserializeObject<T>(jsonString);
    }
}
