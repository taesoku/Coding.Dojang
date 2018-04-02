using System;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question004IsSlurpy
    {

        // time taken: 01:47:17:86
        public static void Answer()
        {

            //var n = int.Parse(Console.ReadLine());
            var n = 4;

            if (n > 10)
            {
                Console.WriteLine("Please type in between 1 to 10.");
                return;
            }

            var inputs = new string[n];

            inputs[0] = "AHDFG"; // yes
            inputs[1] = "ADFGCDFFFFFG"; // yes
            inputs[2] = "ABAEFGCCDFEFFFFFG"; // no
            inputs[3] = "DFGAH"; // no

            //for (int i = 0; i < n; i++)
            //{
            //    inputs[i] = Console.ReadLine();

            //    if(inputs[i].Length > 60)
            //    {
            //        Console.WriteLine("String has to be less than 60 characters.");
            //        return;
            //    }

            //}

            Console.WriteLine("SLURPYS OUTPUT");
            for (int i = 0; i < n; i++) Console.WriteLine(IsSlurpy(inputs[i]) ? "Yes" : "No");
            Console.WriteLine("END OF OUTPUT");

        }

        public static bool IsSlump(string input)
        {
            var isSlump = false;
            if (input.Length <= 2) return false;
            if ((input[0] == 'D' || input[1] == 'E') && input[1] == 'F')
                for (int i = 2; i < input.Length; i++)
                {
                    if (input[i] == 'F') continue;
                    if ((input[i] == 'D' || input[i] == 'E') && input[i + 1] == 'F')
                        isSlump = IsSlump(input.Substring(i));
                    else if (i == input.Length - 1 && input[i] == 'G')
                    {
                        isSlump = true;
                        break;
                    }
                }
            return isSlump;
        }

        public static bool IsSlimp(string input)
        {
            var isSlimp = false;
            if (input[0] == 'D' || input[0] == 'E')
            {
                var i = input.IndexOf('G');
                if (i > 0) isSlimp = IsSlump(input.Substring(0, i + 1));
                return isSlimp;
            }
            if (input[0] == 'H') return IsSlump(input.Substring(1));
            if (input[0] == 'B')
            {
                var i = input.IndexOf('C');
                if (i > 0) isSlimp = IsSlurpy(input.Substring(1, i - 1));
                if (isSlimp) isSlimp = IsSlimp(input.Substring(i + 2));
            }
            return isSlimp;
        }

        public static bool IsSlurpy(string input)
        {
            input = input.ToUpper();
            if (input[input.Length - 1] != 'G') return false;
            if (input[0] == 'A') return IsSlimp(input.Substring(1));
            return false;
        }

    }
}
