using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question095ProfessorIndexes
    {

        public static void Answer()
        {
            //var output = ProfessorIndexes();
            var inputs = new List<int> { 15, 10, 7, 4, 0, 0, 0 };
            ProfessorIndexes(inputs);
        }

        public static void ProfessorIndexes(List<int> inputs)
        {
            var hIndex = GetHIndex(inputs);
            var gIndex = GetGIndex(inputs);
        }

        public static int GetHIndex(List<int> inputs)
        {
            var hIndex = 0;
            for (int i = inputs.Count; i >= 0; i--)
            {
                var curr = inputs.Count(c => c >= i);
                if (inputs.Count(c => c >= i) == i) hIndex = i;
            }
            return hIndex;
        }

        public static int GetGIndex(List<int> inputs)
        {
            var sum = inputs.Sum();
            for (int i = inputs.Count; i > 0; i--)
            {
                if (i * i == sum) return i;
                else sum -= inputs[i - 1];
            }
            return 0;
        }

    }
}