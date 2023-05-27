namespace Game
{
    class PrerenderEngine
    {
        static public void Prerender(List<IRenderable> renderableEntities, string[][] prerenderableView)
        {
            foreach (IRenderable entity in renderableEntities)
                for (var i = 0; i < entity.shape.Length; i++)
                {

                    for (var j = 0; j < entity.shape[i].Length; j++)
                    {
                        if (entity.shape[i][j] != " ")
                        {
                            prerenderableView[entity.Point["Y"] - i][entity.Point["X"] + j] = entity.shape[i][j];

                        }
                    }
                }

        }
    }
}