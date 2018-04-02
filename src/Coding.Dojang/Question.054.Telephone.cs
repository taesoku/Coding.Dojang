using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang.Dojang
{
    public class Question054Telephone
    {

        // time taken: 
        public static void Answer()
        {
            var n = int.Parse(Console.ReadLine());

            var inputs = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Replace("-", "");
                inputs.Add(temp);
            }

            var telephone = Telephone(inputs);
            var sortedList = telephone.Where(t => telephone.Count(t.Contains) > 1).OrderBy(t => t).GroupBy(t => t).Select(t => t.Key).ToList();
            if (sortedList.Count == 0) Console.WriteLine("No duplicates");
            foreach (var sorted in sortedList)
            {
                var count = telephone.Count(sorted.Contains);
                Console.WriteLine(sorted + " " + count);
            }

        }

        public static List<string> Telephone(List<string> inputs)
        {
            var telephone = new List<string>();
            foreach (var input in inputs)
            {
                var check = 0;
                var output = string.Empty;
                foreach(var i in input)
                {
                    var verification = int.TryParse(i.ToString(), out check);
                    if (i.ToString() == "A" || i.ToString() == "B" || i.ToString() == "C") output += "2";
                    else if (i.ToString() == "D" || i.ToString() == "E" || i.ToString() == "F") output += "3";
                    else if (i.ToString() == "G" || i.ToString() == "H" || i.ToString() == "I") output += "4";
                    else if (i.ToString() == "J" || i.ToString() == "K" || i.ToString() == "L") output += "5";
                    else if (i.ToString() == "M" || i.ToString() == "N" || i.ToString() == "O") output += "6";
                    else if (i.ToString() == "P" || i.ToString() == "R" || i.ToString() == "S") output += "7";
                    else if (i.ToString() == "T" || i.ToString() == "U" || i.ToString() == "V") output += "8";
                    else if (i.ToString() == "W" || i.ToString() == "X" || i.ToString() == "Y") output += "9";
                    else if (verification) output += i.ToString();
                }
                output = output.Insert(3, "-");
                telephone.Add(output);
            }
            return telephone;
        }

    }

}
