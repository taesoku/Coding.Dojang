using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{

    public static class Question035FindElected
    {

        public static void Answer()
        {
            var inputs = new List<List<int>> ();
            inputs.Add(new List<int> {1, 2, 3});
            inputs.Add(new List<int> {2, 1, 3});
            inputs.Add(new List<int> {2, 3, 1});
            inputs.Add(new List<int> {1, 2, 3});
            inputs.Add(new List<int> {3, 1, 2});
            var output = FindElected(inputs, 3);
        }

        public static int FindElected(List<List<int>> inputs, int n)
        {
            var temps = new int[n + 1].ToList();
            foreach (var input in inputs) temps[input.First()]++;
            var outputs = temps.Where(t => t != 0).OrderByDescending(t => t);
            if (outputs.First() >= inputs.Count/2)
                return temps.FindIndex(t => t == outputs.First());
            var min = outputs.Last();
            for (int i = 0; i <= n; i++) if (min == temps[i])
                foreach (var input in inputs) if (i == input.First()) inputs.RemoveAt(0);
            return FindElected(inputs, n);
        }

    }

}
