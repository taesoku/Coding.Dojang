using System.Text;
namespace Coding.Dojang
{
    public static class Question116FindLookAndSaySequence
    {

        public static void Answer()
        {
            var output1 = FindLookAndSaySequence(100, 100);
        }

        public static string FindLookAndSaySequence(int index, int input, string num = "1")
        {
            for (int i = 0; i < input; i++)
                num = FindLookAndSaySequenceLoop(num);
            return num[index].ToString();
        }

        public static string FindLookAndSaySequenceLoop(string input)
        {
            var count = 0;
            var curr = default(char);
            var output = new StringBuilder();

            foreach (var c in input)
            {
                if (c != curr)
                {
                    if (curr == default(char))
                    {
                        count = 1;
                        curr = c;
                        output.Append(curr);
                    }
                    else
                    {
                        output.Append(count);
                        count = 1;
                        curr = c;
                        output.Append(curr);
                    }
                }
                else count++;
            }
            output.Append(count);
            return output.ToString();
        }

        public static string FindLookAndSaySequenceRecursive(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            if (input.Length == 1) return input[0] + "1";
            if (input[input.Length - 1] != input[input.Length - 2])
                return FindLookAndSaySequenceRecursive(input.Substring(0, input.Length - 1)) + input[input.Length - 1] + "1";
            var recursive = FindLookAndSaySequenceRecursive(input.Substring(0, input.Length - 1));
            var index = int.Parse(recursive.Substring(recursive.Length - 1, 1)) + 1;
            return recursive.Substring(0, recursive.Length - 1) + index.ToString();
        }

    }
}
