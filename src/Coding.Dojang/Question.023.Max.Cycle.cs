namespace Coding.Dojang
{
    public static class Question023MaxCycle
    {

        public static void Answer()
        {
            var output1 = MaxCycle(1, 10);
            var output2 = MaxCycle(100, 200);
            var output3 = MaxCycle(201, 210);
            var output4 = MaxCycle(900, 1000);
        }

        public static int MaxCycle(int i, int j)
        {
            var max = 0;
            while (i <= j)
            {
                var curr = FindCycle(i++);
                max = curr > max ? curr : max;
            }
            return max;
        }

        public static int FindCycle(int i)
        {
            var count = 1;
            do
            {
                i = i%2 == 0 ? i/2 : i*3 + 1;
                count++;
            } while (i != 1);
            return count;
        }

    }
}