using System.Runtime.InteropServices;

namespace Coding.Dojang
{
    public static class Question003GetLCD
    {

        public static void Answer()
        {
            var output1 = GetLCD(2, "12345");
            var output2 = GetLCD(3, "67890");
        }

        public static string[] GetLCD(int n, string input)
        {
            var row = n*2 + 3;
            var outputs = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                var curr = input[i].ToString();
                for (int j = 0; j < row; j++)
                {
                    if (j == 0 || j == row - 1)
                    {
                        if (curr == "1" || curr == "4" || (j == row - 1 && curr == "7"))
                        {
                            outputs[i] += "\n";
                            continue;
                        }
                        outputs[i] += " " + string.Empty.PadLeft(n).Replace(" ", "-") + " ";
                    }
                    else if (j == n + 1)
                    {
                        if (curr == "1" || curr == "7" || curr == "0")
                        {
                            outputs[i] += "\n";
                            continue;
                        }
                        outputs[i] += " " + string.Empty.PadLeft(n).Replace(" ", "-") + " ";
                    }
                    else if (j < n + 1)
                    {
                        outputs[i] += curr == "1" || curr == "2" || curr == "3" || curr == "7" ? " " : "|";
                        outputs[i] += string.Empty.PadLeft(n);
                        outputs[i] += curr == "5" || curr == "6" ? " " : "|";
                    }
                    else
                    {
                        outputs[i] += curr == "2" || curr == "6" || curr == "8" || curr == "0" ? "|" : " ";
                        outputs[i] += string.Empty.PadLeft(n);
                        outputs[i] += curr == "2" ? " " : "|";
                    }
                    outputs[i] += "\n";
                }
            }
            return outputs;
        }

    }
}
