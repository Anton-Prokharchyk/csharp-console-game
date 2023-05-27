namespace Game
{
    class Player : IRenderable
    {

        public string[][] shape { get; set; } = new string[3][] {
            new string[3]{"/","'","\\"},
            new string[3]{"[","s","]"},
            new string[3]{" ","o"," "}
        };
        public int startPointX { get; set; } = 1;
        public int startPointY { get; set; } = 6;
        public int jumpStage;
        public bool isMoving;
        public Player() { }
        public Player(int coordX, int coordY)
        {
            startPointX = coordX;
            startPointY = coordY;

        }
        public void Jump()
        {
            jumpStage++;
            switch (jumpStage)
            {
                case 1:
                case 2:
                    startPointY--;
                    break;
                case 3:
                case 4:
                    startPointY++;
                    break;
                case 5:
                    isMoving = false;
                    jumpStage = 0;
                    break;

            }
        }
    }
}
