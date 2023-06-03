namespace Game
{
    public abstract class Unit : IRenderable, IMovable
    {
        public string[][]? shape { get; set; }
        public Dictionary<string, int> point { get; set; }
        public IJumpable jumpable { get; set; }
        public IWalkable walkable { get; set; }
        public void Move() { }
    }
}