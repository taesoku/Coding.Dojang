using System;
using System.Collections.Generic;
 
namespace Coding.Dojang
{
    public class Question061BubbleSort
    {

        public static void Answer()
        {
            var inputs1 = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            var inputs2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            BubbleSort(inputs1, inputs1.Count);
            BubbleSort(inputs2, inputs2.Count);
        }

        public static void BubbleSort(List<int> inputs, int n, int loop = 1, int swap = 0)
        {
            var isSorted = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (inputs[i] > inputs[i + 1])
                {
                    var temp = inputs[i];
                    inputs[i] = inputs[i + 1];
                    inputs[i + 1] = temp;
                    isSorted = false;
                    swap++;
                }
            }
            if (isSorted) Console.WriteLine("Loop: " + loop + ", Swap: " + swap);
            else BubbleSort(inputs, n - 1, ++loop, swap);
        }

    }
}
