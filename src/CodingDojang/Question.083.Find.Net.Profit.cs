using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question083FindNetProfit
    {

        public static void Answer()
        {
            var inputs = new List<int> {10, -10, 5, -5};
            var output = FindNetProfit(10000, inputs);
        }

        public static int FindNetProfit(int income, List<int> inputs)
        {
            var price = (decimal) income;
            foreach (var input in inputs)
                price += price * input / 100;
            return (int) Math.Floor(price - income);
        }

    }
}
