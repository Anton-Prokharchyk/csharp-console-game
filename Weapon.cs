namespace Game
{
    class Weapon
    {

        public int startPointX { get; set; } = 3;
        public int startPointY { get; set; } = 7;

        public string[][] shape { get; set; } = new string[][] {
            new string[]{"}"},
        };


        public bool isMoving;
        public int jumpStage;
        public Weapon() { }
        public Weapon(int coordX, int coordY)
        {
            startPointX = coordX;
            startPointY = coordY;
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
