namespace Game
{
    public enum Codes
    {
        MOVE = 1,
        TURN = 2,
        STOP = 3
    }
    public class Game
    {
        static private int MapX = 70;
        static private int MapY = 10;
        static private string Keycap = "";
        static private decimal time = 0;
        static private List<Arrow> Objects = new List<Arrow> { };

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

            DateTimeOffset moment = DateTimeOffset.UtcNow;
            decimal unixTimestampMillisecodns = getUnixTimestampMillisecondsFromDateTimeOffset(moment);
            // System.Console.WriteLine(unixTimestampMillisecodns);


            while (Keycap != "Escape")
            {
                DateTimeOffset nowOffset = getNowDateTimeOffset();
                decimal nowUnixTimestamp = getUnixTimestampMillisecondsFromDateTimeOffset(nowOffset);
                if (Decimal.Round(unixTimestampMillisecodns, 1) != Decimal.Round(nowUnixTimestamp, 1))
                {

                    System.Console.Clear();
                    unixTimestampMillisecodns = nowUnixTimestamp;
                    string[][] pixeledMap = generatePixelMap();

                    keyPressListener();
                    if (Keycap == "F")
                    {
                        // string RainbowLine = myarr[RainbowLineIndex];
                        // RainbowLine[indexOfRainbow] = ">";

                        Objects.Add(new Arrow(4, 7));
                        Keycap = "";

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
                    string generatedMap = generateMap(pixeledMap);
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

        }
        static private void keyPressListener()
        {
            if (System.Console.KeyAvailable)
            {
                Keycap = System.Console.ReadKey(true).Key.ToString();
                // System.Console.Beep(370, 200);
            }
        }

        static public string[][] generatePixelMap()
        {

            string[][] pixelesMap = new string[MapY][];

            for (int i = 0; i < pixelesMap.Length; i++)
            {
                // generate and fill columns
                string[] line = new string[MapX];
                for (int j = 0; j < line.Length; j++)
                {
                    // generate and fill lines
                    if (i + 1 == pixelesMap.Length)
                    { line[j] = "_"; }
                    else if (j != 0 && j + 1 != line.Length)
                    { line[j] = "-"; }
                    if (j == 0 || j + 1 == line.Length)
                    { line[j] = "|"; }
                }
                pixelesMap[i] = line;
            }
            return pixelesMap;
        }
        static public string generateMap(string[][] pixelsMap)
        {
            string[] generatedMapShape = new string[MapY];

            for (int i = 0; i < MapY; i++)
            {
                generatedMapShape[i] = string.Join("", pixelsMap[i]);
            }
            return string.Join("\n", generatedMapShape);

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
