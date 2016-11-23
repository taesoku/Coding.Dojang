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
            var curr = new StringBuilder();
            var output = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                curr.Append("X");
                output.Append(string.Empty.PadLeft(n - i));
                output.Append(curr);
                output.Append("\n");
            }
            return output.ToString().Replace(" ", "0");
        }

    }
}