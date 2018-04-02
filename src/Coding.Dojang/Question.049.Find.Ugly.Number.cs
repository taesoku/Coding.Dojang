using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Coding.Dojang
{
    public class Question049FindUglyNumber
    {

        // time taken: 01:12:06:75
        public static void Answer()
        {
            FindUglyNumber(100000);
        }

        public static string FindUglyNumber(int n)
        {
            var outputs = new List<string>();
            outputs.Add("1");
            int two = 0, three = 0, five = 0;
            for (int i = 1; i < n; i++)
            {
                var temp = FindMin(BigInteger.Parse(outputs[two]) * 2, BigInteger.Parse(outputs[three]) * 3,
                    BigInteger.Parse(outputs[five]) * 5);
                if (temp % 2 == 0 && temp >= 2) two++;
                if (temp % 3 == 0 && temp >= 3) three++;
                if (temp % 5 == 0 && temp >= 5) five++;
                outputs.Add(temp.ToString());
            }
            return outputs.Last();
        }

        public static BigInteger FindMin(BigInteger two, BigInteger three, BigInteger five)
        {
            if (two <= three && two <= five) return two;
            if (three <= two && three <= five) return three;
            if (five <= two && five <= three) return five;
            return 1;
        }

    }
}
