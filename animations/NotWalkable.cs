namespace Game
{
    class NotWalkable : IWalkable
    {
        public bool isWalking { get; set; }
        public KeycapMoves walkDirection { get; set; }
        public void walk()
        {
            System.Console.WriteLine($"I cannot walk!");
        }
        public void walk(Dictionary<string, int> point) { }
    }
}