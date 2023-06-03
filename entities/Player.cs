namespace Game
{
    class Player : Unit, IMovable
    {
        public Player(IJumpable jumpable, IWalkable walkable)
        {
            this.point = new Dictionary<string, int>() { { "X", 9 }, { "Y", 7 } };
            this.shape = new string[3][] {
            new string[3]{"/","'","\\"},
            new string[3]{"[","s","]"},
            new string[3]{" ","o"," "}
        };
            this.jumpable = jumpable;
            this.walkable = walkable;
        }
        public bool isJumping
        {
            get => jumpable.isJumping;
            set => jumpable.isJumping = value;
        }
        public bool isWalking
        {
            set => walkable.isWalking = value;
        }
        public KeycapMoves walkDirection
        {
            set => walkable.walkDirection = value;
        }
        public void Move()
        {
            // TODO: move out into separate method
            this.jumpable.jump(point);
            this.walkable.walk(point);
        }
    }

}
