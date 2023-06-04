namespace Game
{
    class Jumpable : IJumpable
    {
        public bool isJumping { get; set; }
        public int jumpStage { get; set; }

        public void jump() { }
        public void jump(Dictionary<string, int> point)
        {
            if (isJumping)
            {
                this.jumpStage++;
                switch (this.jumpStage)
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
                        this.isJumping = false;
                        this.jumpStage = 0;
                        break;

                }
            }
        }
    }
}