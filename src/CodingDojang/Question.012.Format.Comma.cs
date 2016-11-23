using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Coding.Dojang
{
    public static class Question012FormatComma
    {

        // time taken: 
        public static void Answer()
        {
            var output1 = FormatComma("1000");
            var output2 = FormatComma("2000000");
            var output3 = FormatComma("-3245.24");
        }

        public static string FormatComma(string input)
        {
            var count = 0;
            var foot = string.Empty;
            var head = string.Empty;
            var output = string.Empty;
            if (input.Contains("."))
            {
                foot = "." + input.Split('.').Last();
                input = input.Split('.').First();
            }
            if (input.Contains("."))
            {
                head = "-";
                input = input.Split('-').Last();
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var curr = input[i];
                output = curr + output;
                count++;
                if (count % 3 == 0 && i != 0 && char.IsNumber(curr)) output = "," + output;
            }
            return output;
        }

    }
}
