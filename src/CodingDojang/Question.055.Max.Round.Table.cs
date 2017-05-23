﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question055MaxRoundTable
    {

        // time taken: 00:52:20:51
        public static void Answer()
        {

            var dummy = 0;
            string input = Console.ReadLine().ToString();

            while (dummy == 0)
            {

                List<string> triangle = input.Split(' ').ToList();
                var a = double.Parse(triangle[0]);
                var b = double.Parse(triangle[1]);
                var c = double.Parse(triangle[2]);

                var temp = (a + b + c) / 2;
                var area = Math.Sqrt(temp * (temp - a) * (temp - b) * (temp - c));
                var radius = area / temp;

                Console.WriteLine("The radius of the round table is: " + Math.Round(radius, 3));
                input = Console.ReadLine().ToString();
                if (input.Length == 0) break;

            }

        }

    }

}
