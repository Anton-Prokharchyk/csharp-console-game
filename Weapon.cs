namespace Game
{
    class Weapon
    {

        private int weaponLocationX;
        private int weaponLocationY;

        public string[][] shapy = new string[][] {
            new string[]{"}"},
        };

        public int startPointY = 7;
        public int startPointX = 3;

        public bool isMoving;
        public int jumpStage;

        public Weapon(int coordX, int coordY)
        {
            weaponLocationX = coordX;
            weaponLocationY = coordY;
        }
        public int WeaponLocationX
        {
            get => WeaponLocationX;
            set
            {
                if (value > 0) WeaponLocationX = value;
            }
        }
        public int WeaponLocationY
        {

            get => WeaponLocationX;
            set
            {
                if (value > 0) WeaponLocationX = value;
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
