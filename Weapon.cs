namespace Game
{
    class Weapon : IRenderable, IMovable
    {
        public string[][] shape { get; set; } = new string[][] {
            new string[]{"}"},
        };
        public Dictionary<string, int> Point
        {
            get;
            set;
        }

        public bool isMoving;
        public int jumpStage;
        public Weapon() { }

        public void Move()
        {
            jumpStage++;
            switch (jumpStage)
            {
                case 1:
                case 2:
                    Point["Y"]--;
                    break;
                case 3:
                case 4:
                    Point["Y"]++;
                    break;
                case 5:
                    isMoving = false;
                    jumpStage = 0;
                    break;

            }
        }
    }
}
