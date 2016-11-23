using System;

namespace Coding.Dojang.Dojang
{
    public class Question051CountSteps
    {

        // time taken: 01:23:53;29
        public static void Answer()
        {
            var output = string.Empty;
            for (int i = 1; i < 1000; i++)
                output += CountSteps(i) + " ";
        }

        public static int CountSteps(int n)
        {
            var sqrt = Math.Sqrt(n);
            if (sqrt % 1 == 0) return (int)(sqrt * 2 - 1);
            var max = (int)Math.Floor(sqrt);
            var count = 2 * max - 1;
            var remainder = n - (max * max);
            for (int i = max; remainder > 0; i--)
            {
                if (i*2 <= remainder)
                {
                    remainder -= i * 2;
                    count += 2;
                }
                if (i <= remainder)
                {
                    remainder -= i;
                    count += 1;
                }
            }
            return count;
        }

    }
}
