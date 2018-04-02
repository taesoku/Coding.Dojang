using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public class Question022MinDistance
    {

        public static void Answer()
        {
            var inputs = new List<int> { 1, 3, 4, 8, 13, 17, 20 };
            MinDistance(inputs);
        }

        public static void MinDistance(List<int> inputs)
        {
            var index = 0;
            if (inputs.Count < 2) return;
            var min = inputs[1] - inputs[0];
            for (int i = 1; i < inputs.Count - 1; i++)
            {
                var temp = inputs[i + 1] - inputs[i];
                if (min > temp)
                {
                    index = i;
                    min = temp;
                }
            }
            Console.WriteLine(inputs[index] + ", " + inputs[index + 1]);
        }

    }
}