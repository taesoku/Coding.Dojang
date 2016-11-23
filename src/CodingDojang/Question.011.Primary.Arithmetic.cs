using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question011PrimaryArithmetic
    {

        // time taken: 00:12:48:92
        public static void Answer()
        {

            var dummy = 0;
            var inputs = new List<string>();
            while (dummy == 0)
            {
                var input = Console.ReadLine().ToString();
                if (input.Count(i => i.ToString().Contains("0")) == 2)
                    break;
                inputs.Add(input);
            }
            
            for (int i = 0; i < inputs.Count; i++)
            {
                var input = inputs[i].Split(' ').ToList();
                PrimaryArithmetic(input[0], input[1]);
            }
                
        }

        public static void PrimaryArithmetic(string input1, string input2)
        {
            var small = input1.Length < input2.Length ? input1 : input2;
            var large = input1.Length < input2.Length ? input2 : input1;
            var sum = 0;

            if (small.Length < large.Length)
            {
                var sub = large.Length - small.Length;
                large = large.Substring(sub);
            }

            for(int i = 0; i < small.Length; i++)
                if (int.Parse(small[i].ToString()) + int.Parse(large[i].ToString()) > 9)
                    sum++;

            if (sum == 0) Console.WriteLine("No carry operation.");
            else if (sum == 1) Console.WriteLine("1 carry operation.");
            else Console.WriteLine(sum + " carry operations.");

        }

    }
}
