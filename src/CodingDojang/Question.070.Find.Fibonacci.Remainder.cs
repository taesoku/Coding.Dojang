using System.Numerics;

namespace Coding.Dojang
{
    public static class Question070FindFinbonacciRemainder
    {

        // time taken: 00:26:31:21
        public static void Answer()
        {
            FindFibonacciRemainder(100);
        }

        public static BigInteger FindFibonacciRemainder(int n)
        {
            BigInteger first = 1;
            BigInteger second = 2;
            BigInteger divider = 4294967291;
            for (int i = 2; i < n; i++)
            {
                var temp = first;
                first = second;
                second = BigInteger.Add(temp, first);
            }
            return BigInteger.Divide(second, divider);
        }

    }
}