namespace Game
{
    public interface IMovable
    {
        public Dictionary<string, int> point { get; set; }
        // Move method is calling every 1 frame
        // Place all move functions ( all fucntions that change X and Y positions ) inside
        public void Move();
    }
}