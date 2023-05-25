namespace Game
{
    class Player
    {

        public string[][] shapy = new string[3][] {
            new string[3]{"/","'","\\"},
            new string[3]{"[","s","]"},
            new string[3]{" ","o"," "}
        };
        public int startPointX;
        public int startPointY;

        public int jumpStage;
        public bool isMoving;

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
