namespace Game
{
    class Arrow
    {
        static private int locationX = 0;
        static private int locationY = 0;
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
                locationX = value;
            }
        }
        public int LocationY
        {
            get => locationY;
            set
            {
                locationY = value;
            }
        }
    }
}
