using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Coding.Dojang
{
    public class Question048AnEasyProblem
    {

        // time taken:
        public static void Answer()
        {

            var dummy = 0;
            List<int> inputs = new List<int>();

            while(dummy == 0)
            {
                var input = int.Parse(Console.ReadLine().ToString());

                if (input == 0)
                    break;

                inputs.Add(input);
            }

            foreach (var input in inputs)
                Console.WriteLine(AnEasyProblem(input));

        }

        public static string AnEasyProblem(int input)
        {

            var binary = "0" + Convert.ToString(input, 2);

            var array = binary.ToCharArray();
            Array.Reverse(array);
            var reverse = new string(array);

            var first = reverse.Substring(0, reverse.IndexOf("10"));
            array = first.ToCharArray();
            array = array.OrderByDescending(a => a).ToArray();
            first = new string(array);

            var second = reverse.Substring(reverse.IndexOf("10"));
            var regex = new Regex(Regex.Escape("10"));
            var replace = regex.Replace(second, "01", 1);

            reverse = first + replace;
            array = reverse.ToCharArray();
            Array.Reverse(array);

            var answer = new string(array);

            return Convert.ToInt32(answer, 2).ToString();

        }

    }
}
