using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question055TheKnightsOfTheRoundTable
    {

        // time taken: 00:52:20:51
        public static void Answer()
        {
            var dummy = 0;
            string input = Console.ReadLine().ToString();

            while(dummy == 0)
            {
                
                List<string> triangle = input.Split(' ').ToList();

                double a = double.Parse(triangle[0]);
                double b = double.Parse(triangle[1]);
                double c = double.Parse(triangle[2]);

                double temp = (a + b + c) / 2;

                double area = Math.Sqrt(temp * (temp - a) * (temp - b) * (temp - c));

                double radius = area / temp;

                Console.WriteLine("The radius of the round table is: " 
                    + Math.Round(radius, 3));

                input = Console.ReadLine().ToString();

                if (input.Length == 0)
                    break;

            }

        }

    }

}
