namespace Game
{
    class Weapon : Unit, IMovable
    {
        public bool isMoving;
        public int jumpStage;
        public Weapon()
        {
            this.point = new Dictionary<string, int>()
        {
            {"X",5},
            {"Y",5},

        };
            this.shape = new string[][] {
            new string[]{"}"},
        };
        }

        public void Move()
        {

        }
    }
}
