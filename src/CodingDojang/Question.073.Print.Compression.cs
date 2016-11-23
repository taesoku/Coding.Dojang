using System.Text;

namespace Coding.Dojang
{
    public static class Question073PrintCompression
    {

        public static void Answer()
        {
            var output = PrintCompression("aaabbcccccca");
        }

        public static string PrintCompression(string input)
        {
            var count = 1;
            var last = input[0].ToString();
            var output = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i].ToString() != last)
                {
                    output.Append(last);
                    output.Append(count);
                    last = input[i].ToString();
                    count = 1;
                    continue;
                }
                count++;
            }
            output.Append(last);
            output.Append(count);
            return output.ToString();
        }

    }
}
