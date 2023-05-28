namespace Game
{
    class Flyable
    {
        public void Fly(Dictionary<string, int> point, bool isFlying)
        {
            if (isFlying)
            {
                point["X"]++;
            }
        }
    }
}