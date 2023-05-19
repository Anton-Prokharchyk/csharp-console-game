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
        static private Weapon? Weapon;
        static private decimal GameTime = 0;
        static private List<Arrow> Objects = new List<Arrow> { };

        static private List<string> Keycaps = new List<string> { };
        static void Main()
        {

            /*
             o
            [s]-}
            /*\
            */
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
                    pixeledMap[Weapon.WeaponLocationY][Weapon.WeaponLocationX] = Weapon.Shape;
                    pixeledMap[Weapon.headLocationY][Weapon.headLocationX] = Weapon.head;
                    pixeledMap[Weapon.body1LocationY][Weapon.body1LocationX] = Weapon.body1;
                    pixeledMap[Weapon.body2LocationY][Weapon.body2LocationX] = Weapon.body2;
                    pixeledMap[Weapon.body3LocationY][Weapon.body3LocationX] = Weapon.body3;
                    pixeledMap[Weapon.leg1LocationY][Weapon.leg1LocationX] = Weapon.leg1;
                    pixeledMap[Weapon.leg2LocationY][Weapon.leg2LocationX] = Weapon.leg2;
                    pixeledMap[Weapon.ballsLocationY][Weapon.ballsLocationX] = Weapon.balls;
                    pixeledMap[Weapon.armLocationY][Weapon.armLocationX] = Weapon.arm;


                    if (Keycaps.Contains(KeycapMoves.F.ToString()))
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";

                        var arrow = new Arrow(Weapon.WeaponLocationX, Weapon.WeaponLocationY);
                        arrow.isMoving = true;
                        Objects.Add(arrow);

                        System.Console.WriteLine(Keycap);

                    }

                    if (Keycaps.Contains(KeycapMoves.UpArrow.ToString()))
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";
                        Weapon.isMoving = true;


                    }

                    if (Weapon.isMoving == true)
                    {
                        Weapon.Move();
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
                    string generatedMap = Map.generateMap(pixeledMap);
                    Keycaps.Clear();
                    System.Console.Clear();
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
