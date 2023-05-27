namespace Game
{
    class Player : IRenderable, IMovable
    {
        private Jumpable _jumpable;
        public string[][] shape { get; set; } = new string[3][] {
            new string[3]{"/","'","\\"},
            new string[3]{"[","s","]"},
            new string[3]{" ","o"," "}
        };
        public int startPointX { get; set; } = 1;
        public int startPointY { get; set; } = 6;
        public Dictionary<string, int> Point
        {
            get;
            set;
        } = new Dictionary<string, int>()
        {
            {"X", 9},
            {"Y", 7}
        };

        public int jumpStage;
        public bool isMoving;
        public Player(Jumpable jumpable)
        {
            _jumpable = jumpable;
            Point = new Dictionary<string, int>() { { "X", 4 }, { "Y", 8 } };
        }
        public Player(Jumpable jumpable, Dictionary<string, int> point)
        {
            _jumpable = jumpable;
            Point = point;

        }
        public void Move()
        {
            // this.Jumpable();
        }
        public void Jump()
        {
            jumpStage++;
            switch (jumpStage)
            {
                case 1:
                case 2:
                    Point["Y"]--;
                    break;
                case 3:
                case 4:
                    Point["Y"]++;
                    break;
                case 5:
                    isMoving = false;
                    jumpStage = 0;
                    break;

            }
        }
    }
}
