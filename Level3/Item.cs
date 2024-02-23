
namespace Level3;

public class ShoutConfig
{
    public string ShoutPrefix { get; set; }
    public bool UseEmojis { get; set; }
    public bool UseUpper { get; set; }
    public bool AllowSwearing { get; set; }

    public ShoutConfig(
        string shoutPrefix = "DefaultPrefix",
        bool useEmojis = true,
        bool useUpper = true,
        bool allowSwearing = false)
    {
        ShoutPrefix = shoutPrefix;
        UseEmojis = useEmojis;
        UseUpper = useUpper;
        AllowSwearing = allowSwearing;
    }
}
public class Item
{
    public required string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    private int Length = 3;

    public void ShoutItemName()
    {
        Console.WriteLine(Name.ToUpper());
    }

    public void ReallyShoutItemName(ShoutConfig shoutConfig)
    {
        string phraseToShout = shoutConfig.ShoutPrefix + Name;
        if (shoutConfig.UseUpper) phraseToShout += phraseToShout.ToUpper();
        if (shoutConfig.UseEmojis) phraseToShout += "🔥🔥🔥";
        if (shoutConfig.AllowSwearing) phraseToShout += "f*** u";
        Console.WriteLine(phraseToShout);
    }

    public override string ToString()
    {
        return Name + ", " + SellIn + ", " + Quality + Length;
    }
}