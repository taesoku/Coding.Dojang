using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question026MinRange
    {

        public static void Answer()
        {

            Console.Write("Please type a number of list: ");
            var n = int.Parse(Console.ReadLine());
            var position = 0;
            var smallest = 0;

            var inputs = new List<int>[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0) inputs[0] = new List<int> { 4, 10, 15, 24, 26 };
                if (i == 1) inputs[1] = new List<int> { 0, 9, 12, 20 };
                if (i == 2) inputs[2] = new List<int> { 5, 18, 22, 30 };
            }

        }

        public static void MinRange(List<List<int>> inputs)
        {
            //var i = 0;
            //var isMin = false;
            //var indexes = new Hashtable();
            //var temp = new int[3];
            //temp.Add(inputs[0][0])
            //var min = ;
            
            //while (!isMin)
            //{
            //    var curr = inputs[i];
                
            //    i = i == inputs.Count - 1 ? 0 : i + 1;
            //}

        }

        public static int MinValue(int[] inputs)
        {
            var outputs = inputs.ToList().OrderBy(i => i).ToList();
            return outputs[2] - outputs[0];
        }



    }

}
