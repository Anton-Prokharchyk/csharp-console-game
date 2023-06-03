namespace Game
{
    class Arrow : Unit, IMovable
    {
        private Flyable _fly;
        public bool isFlying = false;

        public Arrow(Flyable fly)
        {
            this.point = new Dictionary<string, int>()
        {
            {"X", 5},
            {"Y", 5}
        };
            this.shape = new string[][]
            {
            new string[]{">"},
            };
            _fly = fly;
        }

        public void Move()
        {
            this._fly.Fly(point, isFlying);
        }
    }
}
