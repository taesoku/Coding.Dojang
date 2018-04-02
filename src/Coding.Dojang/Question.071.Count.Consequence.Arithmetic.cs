using System;
using System.Linq;
using System.Numerics;

namespace Coding.Dojang
{
    public static class Question071CountConsequenceArithmetic
    {

        public static void Answer()
        {
            var count = CountConsequenceArithmetic(100);
        }

        public static int CountConsequenceArithmetic(int n)
        {
            var count = 0;
            var input = "123456789";
            var operators = "+- ";

            for (int i = 0; i < Math.Pow(3, 8); i++)
            {
                var line = input.First().ToString();
                var temp = i;
                for (int j = 1; j <= 8; j++)
                {
                    var index = temp % 3;
                    temp = temp / 3;
                    line += operators[index].ToString().Replace(" ", "") + input[j];
                }
                count = Validation(line) == 0 ? 1 : 0;
            }

            return count;
        }

        public static int Validation(string line)
        {
            var converts = Array.ConvertAll(line.Split('+', '-'), Convert.ToInt32);
            var operations =
                Array.ConvertAll(
                    line.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0')
                        .Where(d => d.Length > 0).ToArray(),
                    d => Convert.ToInt32((d == "+" ? 1 : -1)));
            var first = converts.First();
            for (int i = 1; i <= converts.Length - 1; i++)
                first += operations[i - 1] * converts[i];
            return first;
        }

    }
}