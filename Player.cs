namespace Game
{
    class Player
    {
        
        private int playerLocationX;
        private int playerLocationY;
        public string[][] shapy = new string[3][] {
            new string[3]{" ","o"," "},
            new string[3]{"[","s","]"},
            new string[3]{"/","'","\\"}
        };
        public int startPointX = 3;
        public int startPointY = 7;

        public int jumpStage;
        public bool isMoving;

        public Player(int coordX, int coordY)
        {
            playerLocationX = coordX;
            playerLocationY = coordY;

        }
        public int PlayerLocationX
        {
            get => PlayerLocationX;
            set
            {
                if (value > 0) PlayerLocationX = value;
            }
        }
        public int PlayerLocationY
        {

            get => PlayerLocationX;
            set
            {
                if (value > 0) PlayerLocationX = value;
            }
        }
        public void Move() 
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
