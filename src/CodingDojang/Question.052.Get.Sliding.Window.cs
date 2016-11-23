using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Coding.Dojang
{

    public class Question052GetSlidingWindow
    {

        public static void Answer()
        {
            var inputs = new List<int> {1, 3, -1, -3, 5, 3, 6, 7};
            var maxs = GetMaxSlidingWindow(inputs, 3);
            var mins = GetMinSlidingWindow(inputs, 3);
            var memory = GC.GetTotalMemory(true);
            var proc = Process.GetCurrentProcess();
        }

        public static int[] GetMaxSlidingWindow(List<int> inputs, int n)
        {
            var max_left = new int[inputs.Count];
            var max_right = new int[inputs.Count];
            max_left[0] = inputs[0];
            max_right[inputs.Count - 1] = inputs[inputs.Count - 1];
            for (int i = 1; i < inputs.Count; i++)
            {
                max_left[i] = i%n == 0 ? inputs[i] : Math.Max(max_left[i - 1], inputs[i]);
                var j = inputs.Count - i - 1;
                max_right[j] = i%n == 0 ? inputs[j] : Math.Max(max_right[j + 1], inputs[j]);
            }
            var outputs = new int[inputs.Count - n + 1];
            for (int i = 0, j = 0; i + n <= inputs.Count; i++)
                outputs[j++] = Math.Max(max_right[i], max_left[i + n - 1]);
            return outputs;
        }

        public static int[] GetMinSlidingWindow(List<int> inputs, int n)
        {
            var min_left = new int[inputs.Count];
            var min_right = new int[inputs.Count];
            min_left[0] = inputs[0];
            min_right[inputs.Count - 1] = inputs[inputs.Count - 1];
            for (int i = 1; i < inputs.Count; i++)
            {
                min_left[i] = i%n == 0 ? inputs[i] : Math.Min(min_left[i - 1], inputs[i]);
                var j = inputs.Count - i - 1;
                min_right[j] = i%n == 0 ? inputs[j] : Math.Min(min_right[j + 1], inputs[j]);
            }
            var outputs = new int[inputs.Count - n + 1];
            for (int i = 0, j = 0; i + n <= inputs.Count; i++)
                outputs[j++] = Math.Min(min_right[i], min_left[i + n - 1]);
            return outputs;
        }

    }
}
