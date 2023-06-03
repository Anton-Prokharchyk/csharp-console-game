namespace Game
{
    public abstract class Unit : IRenderable
    {
        public string[][] shape { get; set; }
        public Dictionary<string, int> point { get; set; }
    }
}