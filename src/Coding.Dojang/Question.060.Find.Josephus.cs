namespace Coding.Dojang
{

    public class Question060FindJosephus
    {

        // time taken: 00:10:03:97
        public static void Answer()
        {
            var answer = FindJosephus(10, 3);
        }

        public static int FindJosephus(int n, int k)
        {
            if (n == 1) return 1;
            return (FindJosephus(n - 1, k) + k - 1)%n + 1;
        }

    }

}
