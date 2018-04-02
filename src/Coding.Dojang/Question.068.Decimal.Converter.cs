using System;
using System.Collections.Generic;
 
 
using System.Threading.Tasks;

namespace Coding.Dojang
{
    public static class Question068DecimalConverter
    {

        // time taken: 00:26:31:21
        public static void Answer()
        {
            Console.WriteLine("Please type a decimal number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type a form to convert: ");
            int convert = int.Parse(Console.ReadLine());

            string solution = string.Empty;

            solution = Division(number, convert, solution);

            Console.WriteLine(solution);
        }

        public static string Division(int number, int convert, string solution)
        {
            int remainder = number % convert;

            solution = ConvertToSymbol(remainder) + solution;
            number = number / convert;

            if (number > convert)
                solution = Division(number, convert, solution);
            else
                solution = ConvertToSymbol(number) + solution;

            return solution;

        }

        public static string ConvertToSymbol(int remainder)
        {
            if (remainder < 10)
                return remainder.ToString();
            else
            {
                switch (remainder)
                {
                    case 10: return "A"; break;
                    case 11: return "B"; break;
                    case 12: return "C"; break;
                    case 13: return "D"; break;
                    case 14: return "E"; break;
                    case 15: return "F"; break;
                }
            }

            return string.Empty;
        }

    }
}
