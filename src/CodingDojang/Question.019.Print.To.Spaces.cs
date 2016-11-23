namespace Coding.Dojang
{
    class Question019PrintToSpaces
    {
        public static void Answer()
        {
            var output = PrintToSpaces("THE\tLIFE\tIS\tTOO\tSHORT");
        }

        public static string PrintToSpaces(string input)
        {
            return input.Replace("\t", " ").Replace(" ", string.Empty.PadLeft(4));
        }

    }
}
