using System;
using System.Collections;
using System.Collections.Generic;

namespace Coding.Dojang
{

    public class Question059FindLargestSubset
    {

        // time taken: 00:45:12:10 + alpha
        public static void Answer()
        {
            var inputs = new List<int> { 1, 6, 10, 4, 7, 9, 5 };
            FindLargestSubset(inputs);
        }

        public static void FindLargestSubset(List<int> inputs)
        {
            var first = 0;
            var last = 0;
            var temp = new Hashtable();
            for (int i = 0; i < inputs.Count; i++)
            {
                var curr = inputs[i];
                var begin = curr;
                var end = curr;
                if (temp.ContainsKey(curr)) continue;
                if (temp.ContainsKey(curr - 1)) begin = (int) temp[curr - 1];
                if (temp.ContainsKey(curr + 1)) end = (int) temp[curr + 1];
                temp[begin] = end;
                temp[end] = begin;
                if (last - first < end - begin)
                {
                    first = begin;
                    last = end;
                }
            }
            Console.WriteLine("First: " + first + ", Last: " + last);
        }

    }

}
