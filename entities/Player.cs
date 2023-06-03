namespace Game
{
    class Player : Unit, IMovable
    {
        private WalkableRight _walkableRight;
        private WalkableLeft _walkableLeft;

        // public int jumpStage;
        // public bool isJumping;
        public bool isWalkingRight;
        public bool isWalkingLeft;
        public Player(Jumpable jumpable, WalkableRight walkableRight, WalkableLeft walkableLeft)
        {
            this.point = new Dictionary<string, int>() { { "X", 9 }, { "Y", 7 } };
            this.shape = new string[3][] {
            new string[3]{"/","'","\\"},
            new string[3]{"[","s","]"},
            new string[3]{" ","o"," "}
        };
            this.jumpable = jumpable;
            _walkableRight = walkableRight;
            _walkableLeft = walkableLeft;
        }
        public bool isJumping
        {
            get => jumpable.isJumping;
            set => jumpable.isJumping = value;
        }
        public void Move()
        {
            // TODO: move out into separate method
            this.jumpable.jump(point);
            this._walkableRight.WalkRight(point, ref isWalkingRight);
            this._walkableLeft.WalkLeft(point, ref isWalkingLeft);
        }
    }
}
