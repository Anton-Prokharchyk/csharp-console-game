namespace Game
{
    class Arrow : IMovable, IRenderable
    {
        private Flyable _fly;
        public string[][] shape { get; set; } = new string[][]
        {
            new string[]{">"},
        };
        public Dictionary<string, int> Point { get; set; } = new Dictionary<string, int>()
        {
            {"X", 5},
            {"Y", 5}
        };
        public bool isFlying = false;

        public Arrow(Flyable fly)
        {
            _fly = fly;
        }

        public void Move()
        {
            this._fly.Fly(Point, isFlying);
        }
    }
}
