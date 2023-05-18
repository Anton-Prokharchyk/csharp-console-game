namespace Game
{
    public enum KeycapMoves
    {
        UpArrow,
        F,
    }
    public class Game
    {
        static private string Keycap = "";
        static private decimal GameTime = 0;
        static private List<Arrow> Objects = new List<Arrow> { };

        static private List<string> Keycaps = new List<string> { };

        static void Main()
        {

            // var @string = "MOVE";
            // var result = Enum.Parse(typeof(Codes), @string);
            // System.Type type = (result.GetType());
            // System.Console.WriteLine((int)'d');


            // System.Console.WriteLine(15f.ToString("C"));

            // string[] myarr = map.Split('|');
            // System.Console.WriteLine(myarr[7]);
            // int indexOfRainbow = 0;
            // for (int i = 0; i < myarr.Length; i++)
            // {
            //     bool isContainsRainbow = myarr[i].Contains("}");
            //     if (isContainsRainbow)
            //     {
            //         indexOfRainbow = myarr[i].IndexOf("}");
            //         System.Console.WriteLine(indexOfRainbow);
            //     }
            // }
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

                    if (Keycaps.Contains(KeycapMoves.F.ToString()))
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";

                        Objects.Add(new Arrow(4, 7));
                        System.Console.WriteLine(Keycap);

                    }

                    if (Keycaps.Contains(KeycapMoves.UpArrow.ToString()))
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";

                        Objects.Add(new Arrow(4, 7));
                        System.Console.WriteLine(Keycap);

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
