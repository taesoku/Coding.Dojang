using System.Collections.Generic;

namespace Coding.Dojang.Dojang
{
    public static class Question028GetSpecialSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { -1, 1, 3, -2, 2 };
            GetSpecialSort(inputs);
        }

        public static void GetSpecialSort(List<int> inputs)
        {
            var buckets = new List<int>[2];
            for (int i = 0; i < inputs.Count; i++)
            {
                var temp = inputs[i] > 0 ? 1 : 0;
                if (buckets[temp] == null) buckets[temp] = new List<int>();
                buckets[temp].Add(inputs[i]);
            }
            var k = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i] == null) continue;
                for (int j = 0; j < buckets[i].Count; j++)
                    inputs[k++] = buckets[i][j];
            }
        }

    }

}
