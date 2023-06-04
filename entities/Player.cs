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
        public new void Move()
        {
            // TODO: move out into separate method
            this.performJump(point);
            this.performWalk(point);
        }
    }

}
