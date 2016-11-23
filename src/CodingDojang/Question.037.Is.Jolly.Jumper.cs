using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{

    public static class Question037IsJollyJumper
    {

        // time taken: 00:16:07:90
        public static void Answer()
        {

            //var input = Console.ReadLine();
            //while(input.Any())
            //{
            //    var number = int.Parse(input.Substring(0, input.IndexOf(' ')));
            //    List<string> jumpers =  input.Substring(input.IndexOf(' ') + 1).Split(' ').ToList();
            //    if (number != jumpers.Count) Console.WriteLine("Not Jolly");
            //    else
            //    {
            //        jumpers.RemoveAll(j => int.Parse(j) < 1 || int.Parse(j) >= number);
            //        if (jumpers.Count == number - 1) Console.WriteLine("Jolly");
            //        else Console.WriteLine("Not Jolly");
            //    }
            //    input = Console.ReadLine();
            //}
            var inputs1 = new List<int> {1, 4, 2, 3};
            var inputs2 = new List<int> {1, 4, 2, -1, 6};
            var outputs1 = IsJollyJumper(inputs1);
            var outputs2 = IsJollyJumper(inputs2);

        }

        public static bool IsJollyJumper(List<int> inputs)
        {
            var bits = new BitArray(inputs.Count);
            for (int i = 0; i < inputs.Count - 1; i++)
            {
                var diff = Math.Abs(inputs[i + 1] - inputs[i]);
                if (diff < 1 || diff >= inputs.Count || bits.Get(diff)) return false;
                bits.Set(diff, true);
            }
            return true;
        }

    }

}
