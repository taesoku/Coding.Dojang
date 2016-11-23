using System;
using System.Collections.Generic;
 
 
using System.Threading.Tasks;

namespace Coding.Dojang
{
    public class Question044Ones
    {
        public static void Answer1(int n)
        {
            int i = 0;
            long s = 0, f = 1;

            while (s >= 0)
            {
                long r = f % n;

                s += r;
                f *= 10;
                i++;

                if (s / n > 0 && s % n == 0)
                    break;

            }

            Console.Write(i + "\n");

            return;
        }

        public static void Answer2(int n)
        {
            int i = 0;
            long f = 1, s = 0;

            while (s >= 0)
            {
                long r = f % n;
                s += r;
                f *= 10;
                i++;

                if (s / n > 0 && s % n == 0)
                    break;
            }

            Console.WriteLine(i);
            return;

        }

        // time taken:
        public static void Answer3(ulong n, ulong factor = 1, ulong sum = 0, int count = 1)
        {
            sum += factor % n;
            if (sum % n == 0 && sum / n > 0)
                Console.WriteLine("Count: " + count);
            else Answer3(n, factor * 10, sum, ++count);
        }

    }
}
