using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Coding.Dojang
{
    public static class Question066CountRefrigerators
    {
        public static void Answer()
        {
            var inputs = new List<IceCream>();
            inputs.Add(new IceCream("-3", "-5"));
            inputs.Add(new IceCream("-15", "-20"));
            inputs.Add(new IceCream("-13", "-18"));
            inputs.Add(new IceCream("-5", "-14"));
            var total = CountRefrigerators(inputs, inputs.First().TempMax);
        }

        public class IceCream
        {
            public int TempDiff { get; set; }
            public int TempMax { get; set; }
            public int TempMin { get; set; }
            public IceCream(string tempMax, string tempMin)
            {
                TempMax = int.Parse(tempMax);
                TempMin = int.Parse(tempMin);
                TempDiff = Math.Abs(TempMax - TempMin);
            }
        }

        public static int CountRefrigerators(List<IceCream> inputs, int curr, int total = 0)
        {
            var max = 0;
            var remainders = new List<IceCream>();
            while (curr >= inputs.First().TempMin)
            {
                var count = 0;
                var temp = new List<IceCream>();
                foreach (var input in inputs)
                {
                    if (input.TempMin <= curr && input.TempMax >= curr) count++;
                    else temp.Add(input);
                }
                if (max < count)
                {
                    max = count;
                    remainders = new List<IceCream>();
                    remainders.AddRange(temp);
                }
                curr--;
            }
            if (max != 0) total++;
            if (remainders.Count != 0) 
                total = CountRefrigerators(remainders, remainders.First().TempMax, total);
            return total;
        }

    }
}
