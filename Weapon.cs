namespace Game
{
    class Weapon
    {
        private int weaponLocationX = 5;
        private int weaponLocationY = 6;
        public int headLocationX = 2;
        public int headLocationY = 7;
        public int armLocationX = 4;
        public int armLocationY = 8;
        public int body1LocationX = 3;
        public int body1LocationY = 8;
        public int body2LocationX = 2;
        public int body2LocationY = 8;
        public int body3LocationX = 1;
        public int body3LocationY = 8;
        public int leg1LocationX = 1;
        public int leg1LocationY = 9;
        public int leg2LocationX = 3;
        public int leg2LocationY = 9;
        public int ballsLocationX = 2;
        public int ballsLocationY = 9;
        public int jump = 0;
        public int jumpHight = 0;
        public bool gotMaxHeight = false;
        public bool isMoving = false;
        static public string shape = "}";
        static public string head = "o";
        static public string body1 = "]";
        static public string body2 = "s";
        static public string body3 = "[";
        static public string arm = "-";
        static public string leg1 = "/";
        static public string leg2 = "\\";
        static public string balls = "*";
        public Weapon(int coordX, int coordY)
        {
            weaponLocationX = coordX;
            weaponLocationY = coordY;
        }
        public int WeaponLocationX
        {
            get => weaponLocationX;
            set
            {
                if (value > 0) weaponLocationX = value;
            }
        }
        public int WeaponLocationY
        {
            get => weaponLocationY;
            set
            {
                if (value > 0) weaponLocationY = value;
            }
        }
        public string Shape
        {
            get => shape;
            set
            {
                shape = value;
            }
        }
        private static IEnumerator<int> getJumpLocation(int loc)
        {
            yield return loc++;
            yield return loc++;
            yield return loc--;
            yield return loc--;
        }
        public void Move()
        {
            System.Console.WriteLine("Hello");
            jump++;
            switch (jump)
            {
                case 1:
                case 2:
                    weaponLocationY--;
                    headLocationY--;
                    body1LocationY--;
                    body2LocationY--;
                    body3LocationY--;
                    armLocationY--;
                    leg1LocationY--;
                    leg2LocationY--;
                    ballsLocationY--;
                    break;
                case 3:
                case 4:
                    weaponLocationY++;
                    headLocationY++;
                    body1LocationY++;
                    body2LocationY++;
                    body3LocationY++;
                    armLocationY++;
                    leg1LocationY++;
                    leg2LocationY++;
                    ballsLocationY++;
                    break;
                case 5:
                    isMoving = false;
                    jump = 0;
                    break;

            }


        }
    }
}
