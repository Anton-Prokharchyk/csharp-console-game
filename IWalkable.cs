namespace Game
{
    public interface IWalkable
    {
        public bool isWalking { get; set; }
        public KeycapMoves walkDirection { get; set; }

        public void walk();
        public void walk(Dictionary<string, int> point);
    }
}