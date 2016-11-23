namespace Coding.Dojang
{
    public static class Question113CountStairSteps
    {

        public static void Answer()
        {
            var count = CountStairSteps(7, 2);
        }

        public static int CountStairSteps(int n, int j)
        {
            var count = 0;
            for (int i = n - 1; i >= j; i--)
            {
                if (j == 0) break;
                count += Fibonacci(i);
                j--;
            }
            return count;
        }

        public static int Fibonacci(int n)
        {
            var first = 0;
            var second = 1;
            for (int i = 1; i <= n; i++)
            {
                var temp = first;
                first = second;
                second += temp;
            }
            return second;
        }

    }
}