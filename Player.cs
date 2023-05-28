namespace Game
{
    class Player : IRenderable, IMovable
    {
        private Jumpable _jumpable;
        private WalkableRight _walkableRight;
        private WalkableLeft _walkableLeft;
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
        public bool isJumping;
        public bool isWalkingRight;
        public bool isWalkingLeft;
        public Player(Jumpable jumpable)
        {
            _jumpable = jumpable;
            Point = new Dictionary<string, int>() { { "X", 4 }, { "Y", 8 } };
        }
        public Player(Jumpable jumpable, WalkableRight walkableRight, WalkableLeft walkableLeft)
        {
            // TODO: move out into separate method
            _jumpable = jumpable;
            _walkableRight = walkableRight;
            _walkableLeft = walkableLeft;
        }
        public void Move()
        {
            // TODO: move out into separate method
            _jumpable.Jump(Point, ref jumpStage, ref isJumping);
            _walkableRight.WalkRight(Point, ref isWalkingRight);
            _walkableLeft.WalkLeft(Point, ref isWalkingLeft);
        }
        // public void Jump()
        // {
        //     jumpStage++;
        //     switch (jumpStage)
        //     {
        //         case 1:
        //         case 2:
        //             Point["Y"]--;
        //             break;
        //         case 3:
        //         case 4:
        //             Point["Y"]++;
        //             break;
        //         case 5:
        //             isMoving = false;
        //             jumpStage = 0;
        //             break;

        //     }
        // }
    }
}
