namespace Game
{
    public abstract class Unit : IRenderable, IMovable
    {
        public string[][]? shape { get; set; }
        // TODO: Create separate Point type class
        public Dictionary<string, int> point { get; set; }
        public IJumpable jumpable { get; set; }
        public IWalkable walkable { get; set; }
        public bool isJumping
        {
            get => jumpable.isJumping;
            set => jumpable.isJumping = value;
        }
        public bool isWalking
        {
            get => walkable.isWalking;
            set => walkable.isWalking = value;
        }
        public KeycapMoves walkDirection
        {
            get => walkable.walkDirection;
            set => walkable.walkDirection = value;
        }
        public void performJump(Dictionary<string, int> point)
        {
            jumpable.jump(point);
        }
        public void performWalk(Dictionary<string, int> point)
        {
            walkable.walk(point);
        }
        public void Move() { }
    }
}