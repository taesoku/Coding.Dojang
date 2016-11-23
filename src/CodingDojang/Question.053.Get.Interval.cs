using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question053GetInterval
    {

        public static void Answer()
        {
            var inputs = new List<Interval>();
            inputs.Add(new Interval(4, 1));
            inputs.Add(new Interval(6, 5));
            inputs.Add(new Interval(9, 6));
            inputs.Add(new Interval(10, 8));
            inputs.Add(new Interval(10, 10));
            var outputs = GetInterval(inputs, inputs.First().Max);
        }

        public class Interval
        {
            public int Count { get; set; }
            public int Max { get; set; }
            public int Min { get; set; }
            public Interval(int max, int min)
            {
                Count = Math.Abs(max - min);
                Max = max;
                Min = min;
            }
        }

        public static List<Interval> GetInterval(List<Interval> inputs, int curr, List<Interval> outputs = null)
        {
            var max = inputs.Max(i => i.Max);
            var temp = inputs.First();
            if (outputs == null) outputs = new List<Interval>();
            var remainders = new List<Interval>();
            foreach (var input in inputs)
            {
                if (input.Max < temp.Min || temp.Max < input.Min)
                {
                    remainders.Add(input);
                    continue;
                }
                if (input.Min < temp.Min) temp.Min = input.Min;
                if (input.Max > temp.Max) temp.Max = input.Max;
            }
            outputs.Add(temp);
            if (remainders.Count != 0) outputs = GetInterval(remainders, remainders.First().Min, outputs);
            return outputs;
        }

    }
}
