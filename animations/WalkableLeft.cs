namespace Game
{
    class WalkableLeft
    {
        public void WalkLeft(Dictionary<string, int> point, ref bool isWalkingLeft)
        {
            if (isWalkingLeft)
            {
                point["X"]--;
                isWalkingLeft = false;
            }
        }
    }
}