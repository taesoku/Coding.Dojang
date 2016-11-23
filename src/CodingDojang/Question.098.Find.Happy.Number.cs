using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question098FindHappyNumbers
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            var output1 = FindHappyNumbers(3);
            var output2 = FindHappyNumbers(7);
            var output3 = FindHappyNumbers(4);
            var output4 = FindHappyNumbers(13);
        }

        public static bool FindHappyNumbers(int input)
        {
            var curr = input;
            var outputs = new HashSet<int>();
            while (true)
            {
                outputs.Add(curr);
                var index = curr.ToString().Length;
                var last = curr;
                curr = 0;
                for (int i = 0; i < index; i++)
                    curr += int.Parse(last.ToString()[i].ToString())
                        * int.Parse(last.ToString()[i].ToString());
                if (outputs.Contains(curr)) return false;
                if (curr == 1) return true;
            }
            return false;
        }

    }
}