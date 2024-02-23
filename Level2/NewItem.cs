namespace Level2_2
{
    public class NewItem
    {
        public required string NewName { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        private int Length = 3;

        public override string ToString()
        {
            return this.NewName + ", " + this.SellIn + ", " + this.Quality + this.Length;
        }
    }
}