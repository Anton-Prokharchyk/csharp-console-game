namespace Game
{
    class Arrow
    {
        public int startPointX { get; set; } = 4;
        public int startPointY { get; set; } = 7;
        public bool isMoving = false;
        public string[][] shape { get; set; } = new string[][] {
            new string[]{">"},};
        public Arrow() { }
        public Arrow(int coordX, int coordY)
        {
            startPointX = coordX;
            startPointY = coordY;
        }
        public int StartPointX
        {
            get => startPointX;
            set
            {
                if (value > 0) startPointX = value;
            }
        }
        public int StartPointY
        {
            get => startPointY;
            set
            {
                if (value > 0) startPointY = value;
            }
        }
        public void Move()
        {
            // if (isMoving) startPointX++;
            startPointX++;
        }
    }
}
