using System.Text;

namespace Coding.Dojang
{
    public class Question041PrintConvertedEventhDigit
    {

        public static void Answer()
        {
            //var input = Console.ReadLine();
            //Console.WriteLine(PrintConvertedEventhDigit(input));
            var output = PrintConvertedEventhDigit("a1b2cde3~g45hi6");
        }

        public static string PrintConvertedEventhDigit(string input)
        {
            var output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var curr = input[i];
                if (i%2 == 1 && char.IsNumber(curr)) output.Append('*');
                else output.Append(curr);
            }
            return output.ToString();
        }

    }
}
