namespace Game
{
    class Arrow
    {
        private int locationX = 0;
        private int locationY = 0;
        public bool isMoving = false;
        static private string shape = ">";
        public Arrow(int coordX, int coordY)
        {
            locationX = coordX;
            locationY = coordY;
        }
        public int LocationX
        {
            get => locationX;
            set
            {
                if (value > 0) locationX = value;
            }
        }
        public int LocationY
        {
            get => locationY;
            set
            {
                if (value > 0) locationY = value;
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
        public void Move()
        {
            // if (isMoving) locationX++;
            locationX++;
        }
    }
}
