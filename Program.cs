namespace Game
{
    // TODO: separate file
    public enum KeycapMoves
    {
        UpArrow,
        F,
        Escape
    }
    public class Game
    {
        static private string Keycap = "";
        static private Weapon Weapon;
        static private Player Player;
        static private decimal GameTime = 0;

        static private List<IRenderable> renderableObjects = new List<IRenderable> { };
        static private List<string> Keycaps = new List<string> { };
        static void Main()
        {

            System.Console.WriteLine("/");
            init();


            while (!Keycaps.Contains(KeycapMoves.Escape.ToString()))
            {
                DateTimeOffset nowOffset = getNowDateTimeOffset();
                decimal nowUnixTimestamp = getUnixTimestampMillisecondsFromDateTimeOffset(nowOffset);

                if (Decimal.Round(GameTime, 1) != Decimal.Round(nowUnixTimestamp, 1))
                {

                    GameTime = nowUnixTimestamp;

                    string[][] pixeledMap = Map.generatePixelMap();

                    keyPressListener();

                    PrerenderEngine.Prerender(renderableObjects, pixeledMap);

                    if (Keycaps.Contains(KeycapMoves.F.ToString()))
                    {
                        var arrow = new Arrow();
                        arrow.isMoving = true;
                        // renderableObjects.Add(arrow);

                        System.Console.WriteLine(Keycap);

                    }

                    if (Keycaps.Contains(KeycapMoves.UpArrow.ToString()))
                    {
                        Player.isMoving = true;
                    }

                    if (Player.isMoving == true)
                    {
                        Player.Jump();
                    }

                    // for (var i = 0; i < renderableObjects.Count; i++)
                    // {

                    //     if (pixeledMap[renderableObjects[i].LocationY][renderableObjects[i].LocationX + 1] != "|")
                    //     {
                    //         renderableObjects[i].Move();
                    //         pixeledMap[renderableObjects[i].LocationY][renderableObjects[i].LocationX] = renderableObjects[i].shape;
                    //     }
                    //     else
                    //     {
                    //         renderableObjects.Remove(renderableObjects[i]);
                    //     }
                    // }
                    System.Console.Clear();
                    string generatedMap = Map.generateMap(pixeledMap);
                    Keycaps.Clear();
                    render(generatedMap);
                }

            }



        }

        static private void render(String map)
        {
            System.Console.WriteLine(map);
        }
        static private void init()
        {
            DateTimeOffset moment = DateTimeOffset.UtcNow;
            GameTime = getUnixTimestampMillisecondsFromDateTimeOffset(moment);
            // Weapon = new Weapon();
            Player = new Player(new Jumpable());
            // renderableObjects.Add(Weapon);
            renderableObjects.Add(Player);

        }
        static private void keyPressListener()
        {
            if (System.Console.KeyAvailable)
            {
                var keycap = System.Console.ReadKey(true).Key.ToString();
                Keycaps.Add(keycap);
                System.Console.WriteLine(keycap);
                // System.Console.Beep(370, 200);
            }
        }

        static public decimal getUnixTimestampMillisecondsFromDateTimeOffset(DateTimeOffset time)
        {
            // example 1683108533.947
            return (decimal)time.ToUnixTimeMilliseconds() / 1000;
        }
        static public DateTimeOffset getNowDateTimeOffset()
        {
            DateTimeOffset utcNow = DateTimeOffset.UtcNow;
            return utcNow;
        }
    }
}
