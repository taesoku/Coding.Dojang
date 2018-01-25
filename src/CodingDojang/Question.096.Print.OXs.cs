using System;
using System.Text;

namespace Coding.Dojang
{
    public static class Question096PrintOXs
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            Console.Write("Please type a number: ");
            var n = int.Parse(Console.ReadLine());
            var output = PrintOXs(n);
        }

        public static string PrintOXs(int n)
        {
            var curr = 0;
            var output = new StringBuilder();
            for (var i = n - 1; i >= 0; i++)
            {
                var temp = Math.Pow(2, i);
                curr += (int)temp;
                var binary = Convert.ToString(curr, 2);
                output.Append(binary.Replace("1", "X").Replace("0", "O"));
                output.Append("\n");
            }
            return output.ToString();
        }

    }
}