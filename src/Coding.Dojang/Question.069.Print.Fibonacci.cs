using System.Numerics;
using System.Text;

namespace Coding.Dojang
{
    public static class Question069PrintFibonacci
    {

        // time taken: 00:26:31:21
        public static void Answer()
        {
            var output = PrintFibonacci(10);
        }

        public static string PrintFibonacci(int n)
        {
            var first = (BigInteger) 1;
            var second = (BigInteger)2;
            var output = new StringBuilder();
            output.Append(first);
            output.Append("\n");
            output.Append(second);
            for (int i = 2; i <= n; i++)
            {
                var temp = first;
                first = second;
                second += temp;
                output.Append("\n");
                output.Append(second);
            }
            return output.ToString();
        }

    }
}