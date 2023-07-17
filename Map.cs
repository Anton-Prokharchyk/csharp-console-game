namespace Game
{
    class Map
    {

        static private int MapX = 70;
        static private int MapY = 10;

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
                    { line[j] = "▔"; }
                    else if (j != 0 && j + 1 != line.Length)
                    { line[j] = " "; }
                    if (j == 0 || j + 1 == line.Length)
                    { line[j] = "┃"; }
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
    }
}