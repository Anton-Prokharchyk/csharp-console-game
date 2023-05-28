namespace Game
{
    class Weapon : IRenderable, IMovable
    {
        public string[][] shape { get; set; } = new string[][] {
            new string[]{"}"},
        };
        public Dictionary<string, int> Point
        {
            get;
            set;
        } = new Dictionary<string, int>()
        {
            {"X",5},
            {"Y",5},

        };

        public bool isMoving;
        public int jumpStage;
        public Weapon() { }

        public void Move()
        {

        }
    }
}
