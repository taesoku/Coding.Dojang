using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding.Dojang
{
    public static class Question093DuplicateNumbers
    {
        // time taken: 00:05:27:21
        public static void Answer()
        {
            
            
            //var input = Console.ReadLine().ToString();
            //var inputs = new List<string>();
            //inputs.Add(input);
            //DuplicateNumbers1(inputs);
        }

        public static bool DuplicateNumbers1(List<string> inputs)
        {
            foreach (var input in inputs)
            {
                if (input.Length != 10) return false;
                Console.WriteLine(input.Distinct().Count() == 10);
            }
            return false;
        }

        public static bool DuplicateNumbers2(List<string> inputs)
        {
            var hash = new HashSet<int>(from i in inputs select int.Parse(i));
            return hash.Count == 10;
        }
    }
}