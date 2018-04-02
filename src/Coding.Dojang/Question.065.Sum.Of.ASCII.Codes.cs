using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question065SumOfASCIICode
    {

        public static void Answer()
        {
            var file = File.ReadAllText("B:\\專門\\Coding.Dojang\\Coding.Dojang\\Question.065.XOR.Decryption.txt").Split(',').ToList();
            var sum = SumOfASCIICodes(file, 0, (FindXORDecryption(file, 0)));
            sum += SumOfASCIICodes(file, 1, (FindXORDecryption(file, 1)));
            sum += SumOfASCIICodes(file, 2, (FindXORDecryption(file, 2)));
            Console.WriteLine(sum);
        }

        public static char FindXORDecryption(List<string> inputs, int n)
        {
            var location = 0;
            var max = 0;
            var outputs = new Hashtable();
            for (int i = n; i < inputs.Count; i += 3)
            {
                var curr = int.Parse(inputs[i]);
                if (outputs.ContainsKey(curr))
                {
                    var count = (int)outputs[curr] + 1;
                    outputs[curr] = count;
                    if (max < count)
                    {
                        max = count;
                        location = curr;
                    }
                }
                else outputs[curr] = 1;
            }
            return (char) (location^32);
        }

        public static int SumOfASCIICodes(List<string> inputs, int n, char xor)
        {
            var sum = 0;
            for (int i = n; i < inputs.Count; i += 3)
                sum += int.Parse(inputs[i]) ^ xor;
            return sum;
        }

    }
}
