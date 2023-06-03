namespace Game
{
    public interface IMovable
    {
        public Dictionary<string, int> point { get; set; }
        public void Move();
    }
}