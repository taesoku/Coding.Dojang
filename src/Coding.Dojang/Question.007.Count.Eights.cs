using System.Linq;
 
namespace Coding.Dojang
{
    public static class Question007CountEights
    {

        // time taken: 00:03:22:04
        public static void Answer()
        {
            var sum = CountEights(10000);
        }

        public static int CountEights(int n)
        {
            var count = 0;
            for (int i = 0; i <= n; i++)
                count += i.ToString().Count(c => c.ToString().Contains("8"));
            return count;
        }

    }
}
