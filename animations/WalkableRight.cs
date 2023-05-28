namespace Game
{
    class WalkableRight
    {
        public void WalkRight(Dictionary<string, int> point, ref bool isWalkingRight)
        {
            if (isWalkingRight)
            {
                point["X"]++;
                isWalkingRight = false;
            }
        }
    }
}