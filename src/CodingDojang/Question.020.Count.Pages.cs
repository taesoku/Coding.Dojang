namespace Coding.Dojang
{
    public class Question020CountPages
    {

        public static void Answer()
        {
            var output1 = CountPages(0, 1);
            var output2 = CountPages(1, 1);
            var output3 = CountPages(2, 1);
            var output4 = CountPages(1, 10);
            var output5 = CountPages(10, 10);
            var output6 = CountPages(11, 10);
        }

        public static int CountPages(int m, int n)
        {
            return m/n + (m%n == 0 ? 0 : 1);
        }

    }
}
