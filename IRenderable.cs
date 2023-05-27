namespace Game
{
    public interface IRenderable
    {
        public string[][] shape { get; set; }
        public Dictionary<string, int> Point { get; set; }

        // public int startPointX { get; set; }
        // public int startPointY { get; set; }

    }
}