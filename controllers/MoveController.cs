namespace Game
{
    class MoveController
    {
        static public void MakeMove(List<IMovable> listOfMovableEntities)
        {
            foreach (IMovable Entity in listOfMovableEntities)
            {
                Entity.Move();
            }

        }
    }
}