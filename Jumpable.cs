namespace Game
{
    class Jumpable
    {
        public void Jump(Dictionary<string, int> point, ref int jumpStage, ref bool isJumping)
        {
            if (isJumping)
            {
                jumpStage++;
                switch (jumpStage)
                {
                    case 1:
                    case 2:
                        point["Y"]--;
                        break;
                    case 3:
                    case 4:
                        point["Y"]++;
                        break;
                    case 5:
                        isJumping = false;
                        jumpStage = 0;
                        break;

                }
            }
        }
    }
}