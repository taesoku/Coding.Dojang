using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question082CountNumericBaseball
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            var inputs = new List<string>();
            inputs.Add("123 1 1");
            inputs.Add("356 1 0");
            inputs.Add("327 2 0");
            inputs.Add("489 0 1");
            var count = CountNumericBaseball(inputs);
        }

        public static int CountNumericBaseball(List<string> inputs)
        {
            var count = 0;
            for (int i = 123; i < 987; i++)
            {
                var curr = i.ToString();
                var total = 0;
                if (curr.Contains("0") || !(curr[0] != curr[1] && curr[1] != curr[2] && curr[0] != curr[2])) continue;
                foreach (var input in inputs)
                {
                    var split = input.Split(' ').ToList();
                    var ball = 0;
                    var strike = 0;
                    var temp = split[0].ToString();
                    for (int j = 0; j < 3; j++)
                    {
                        if (curr[j] == temp[j]) strike++;
                        else if (curr.Contains(temp[j])) ball++;
                    }
                    if (ball == int.Parse(split[2]) && strike == int.Parse(split[1])) total++;
                }
                if (total == 4) 
                    count++;
            }
            return count;
        }

    }
}
