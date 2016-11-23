using System;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question077CountCellSimulations
    {

        public static void Answer()
        {
            var output1 = CountCellSimulations("00011101");
            var output2 = CountCellSimulations("000");
            var output3 = CountCellSimulations("000001");
            var output4 = CountCellSimulations("11110");
        }

        public static int CountCellSimulations(string input)
        {
            var count = 0;
            var temp = input.Length*input.Length;
            for (int i = 0; i < temp; i++)
            {
                var curr = Convert.ToString(i, 2);
                curr = string.Empty.PadLeft(input.Length - curr.Length).Replace(" ", "0") + curr;
                var output = PrintCellSimulations(curr);
                if (input == output) count++;
            }
            return count;
        }

        public static string PrintCellSimulations(string input)
        {
            input = input.Last() + input + input.First();
            var output = string.Empty;
            for (int i = 1; i < input.Length - 1; i++)
            {
                var next = input[i + 1];
                var prev = input[i - 1];
                output += next == prev ? input[i] : (input[i] == '0' ? '1' : '0');
            }
            return output;
        }

    }
}
