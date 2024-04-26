namespace Level1
{
    public class Item
    {
        public required string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        private int Length = 3;

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality + this.Length;
        }
    }
}