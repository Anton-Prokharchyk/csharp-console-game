namespace Game
{
    // TODO: separate file
    public enum KeycapMoves
    {
        UpArrow,
        F,
    }
    public class Game
    {
        static private string Keycap = "";
        static private Weapon Weapon;
        static private Player Player;
        static private decimal GameTime = 0;

        static private List<Arrow> Objects = new List<Arrow> { };
        static private List<string> Keycaps = new List<string> { };
        static void Main()
        {

            System.Console.WriteLine("/");
            init();

            while (Keycap != "Escape")
            {
                DateTimeOffset nowOffset = getNowDateTimeOffset();
                decimal nowUnixTimestamp = getUnixTimestampMillisecondsFromDateTimeOffset(nowOffset);
                if (Decimal.Round(GameTime, 1) != Decimal.Round(nowUnixTimestamp, 1))
                {

                    GameTime = nowUnixTimestamp;
                    string[][] pixeledMap = Map.generatePixelMap();
                    keyPressListener();

                    for (var i = 0; i < Player.shapy.Length; i++)
                    {

                        for (var j = 0; j < Player.shapy[i].Length; j++)
                        {
                            if (Player.shapy[i][j] != " ")
                            {
                                pixeledMap[Player.startPointY - i][Player.startPointX + j] = Player.shapy[i][j];
                            }
                        }
                    }

                    if (Keycaps.Contains(KeycapMoves.F.ToString()))
                    {
                        var arrow = new Arrow(Weapon.WeaponLocationX, Weapon.WeaponLocationY);
                        arrow.isMoving = true;
                        Objects.Add(arrow);

                        System.Console.WriteLine(Keycap);

                    }

                    if (Keycaps.Contains(KeycapMoves.UpArrow.ToString()))
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";
                        Player.isMoving = true;


                    }

                    if (Player.isMoving == true)
                    {
                        Player.Jump();
                    }

                    for (var i = 0; i < Objects.Count; i++)
                    {






                        if (pixeledMap[Objects[i].LocationY][Objects[i].LocationX + 1] != "|")
                        {
                            Objects[i].Move();
                            pixeledMap[Objects[i].LocationY][Objects[i].LocationX] = Objects[i].Shape;
                        }
                        else
                        {
                            Objects.Remove(Objects[i]);
                        }
                    }
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
            Weapon = new Weapon(5, 8);
            Player = new Player(1, 6);
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
