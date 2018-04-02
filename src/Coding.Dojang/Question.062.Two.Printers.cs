using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question062TwoPrinters
    {

        // time taken: 00:26:20:17
        public static void Answer()
        {
            
            var number = int.Parse(Console.ReadLine().ToString());
            var inputLines = new List<string>(number);
        
            for (int i = 0; i < number; i++)
                inputLines.Add(Console.ReadLine().ToString());

            for(int i = 0; i < number; i++)
            {
                var inputs = inputLines[i].Split(' ').ToList();
                TwoPrinters2(int.Parse(inputs.First()), int.Parse(inputs[1]), int.Parse(inputs.Last()));
            }

        }

        public static void TwoPrinters1(int x, int y, int p)
        {
            
            var sum = x + y;
            var division1 = (decimal)y / sum;
            var division2 = (decimal)x / sum;

            var answer1 = x < y ? Math.Ceiling(division1 * p) : Math.Floor(division1 * p);
            var answer2 = x < y ? Math.Floor(division2 * p) : Math.Ceiling(division2 * p);

            Console.WriteLine(Math.Max(answer1 * x, answer2 * y));

        }

        public static void TwoPrinters2(int x, int y, int p)
        {
            var sum = x + y;
            var division1 = (decimal)y * p / sum;
            var division2 = (decimal)x * p / sum;
            var answer1 = x < y ? Math.Ceiling(division1) : Math.Floor(division1);
            var answer2 = x < y ? Math.Floor(division2) : Math.Ceiling(division2);
            Console.WriteLine(Math.Max(answer1 * x, answer2 * y));
        }

    }
}
