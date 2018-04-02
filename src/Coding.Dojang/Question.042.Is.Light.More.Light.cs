using System;

namespace Coding.Dojang
{
    public class Question042IsLightMoreLight
    {

        // time taken: 00:20:43:61
        public static void Answer()
        {
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "0") return;
                if (IsLightMoreLight(long.Parse(input))) Console.WriteLine("yes");
                else Console.WriteLine("no");
            }
        }

        public static bool IsLightMoreLight(long n)
        {
            return Math.Sqrt(n)%1 == 0;
        }

    }
}
