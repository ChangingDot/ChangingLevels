
namespace Level3;
public class Item
{
    public required string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    private int Length = 3;

    public override string ToString()
    {
        return Name + ", " + SellIn + ", " + Quality + Length;
    }
}