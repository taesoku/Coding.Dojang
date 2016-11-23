using System.Collections;

namespace Coding.Dojang
{
    public static class Question001SumOfSelfNumbers
    {

        public static void Answer()
        {
            var sum = SumOfSelfNumbers(5000); // 1227365
        }

        public static int SumOfSelfNumbers(int n)
        {
            var sum = 0;
            var outputs = new Hashtable();
            for (int i = 1; i < n; i++)
            {
                var d = i/1000 + i%1000/100 + i%100/10 + i%10 + i;
                outputs[d] = i;
            }
            for (int i = 1; i <= n; i++) sum += outputs.ContainsKey(i) ? 0 : i;
            return sum;
        }

    }
}
