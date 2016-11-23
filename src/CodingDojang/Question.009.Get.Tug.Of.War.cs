using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question009GetTugOfWar
    {

        // time taken: 02:33:38:75
        public static void Answer()
        {
            var inputs = new List<int> {100, 90, 200};
            var output = GetTugOfWar(inputs, new bool[inputs.Count], new bool[inputs.Count], Int32.MaxValue);
            var a = 0;
            var b = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                if (output[i]) a += inputs[i];
                if (!output[i]) b += inputs[i];
            }
            var small = a < b ? a : b;
            var large = a < b ? b : a;
        }

        public static bool[] GetTugOfWar(List<int> inputs, bool[] selected, bool[] solution, int minDiff, int index = 0)
        {
            var size = 0;
            for (int i = 0; i < inputs.Count; i++) if (selected[i]) size++;
            if (inputs.Count/2 == size)
            {
                var diff = GetDiff(inputs, selected);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    for (int i = 0; i < inputs.Count; i++) solution[i] = selected[i];
                }
            }
            if (index >= inputs.Count) return solution;
            selected[index] = true;
            GetTugOfWar(inputs, selected, solution, minDiff, index + 1);
            selected[index] = false;
            GetTugOfWar(inputs, selected, solution, minDiff, index + 1);
            return solution;
        }

        public static int GetDiff (List<int> inputs, bool[] selected)
        {
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < inputs.Count; i++)
                if (selected[i]) leftSum += inputs[i];
                else rightSum += inputs[i];
            return Math.Abs(rightSum - leftSum);
        }

    }

}
