using System;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question008CountIntervalDays
    {

        // time taken: 00:26:08:13
        public static void Answer()
        {
            //var inputs = Console.ReadLine().Split(' ').ToList();
            //var answer = Subdate(inputs[0], inputs[1]);
            //Console.WriteLine(answer);
            var output1 = CountIntervalDays("20070515", "20070501");
            var output2 = CountIntervalDays("20070501", "20070515");
            var output3 = CountIntervalDays("20070301", "20070515");
            var output4 = CountIntervalDays("20110101", "20120101");
            var output5 = CountIntervalDays("20110105", "20111205");
            var output6 = CountIntervalDays("20040831", "20040120");
        }

        public static int CountIntervalDays(string a, string b)
        {
            var firstYear = int.Parse(a.Substring(0, 4));
            var firstMonth = int.Parse(a.Substring(4, 2));
            var firstDay = int.Parse(a.Substring(6, 2));
            var secondYear = int.Parse(b.Substring(0, 4));
            var secondMonth = int.Parse(b.Substring(4, 2));
            var secondDay = int.Parse(b.Substring(6, 2));
            var first = firstDay + CountYear(firstYear, firstMonth) + CountMonth(firstMonth, firstYear);
            var second = secondDay + CountYear(secondYear, secondMonth) + CountMonth(secondMonth, secondYear);
            return Math.Abs(first - second);
        }

        public static int CountMonth(int month, int year)
        {
            var days = 0;
            for (int i = 1; i < month; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10)
                    days += 31;
                else if (i == 4 || i == 6 || i == 9 || i == 11) days += 30;
                else if (year%4 == 0) days += 29;
                else days += 28;
            }
            return days;
        }

        public static int CountYear(int year, int month)
        {
            return year*365 + year/4 - (year%4 == 0 && month < 3 ? 1 : 0);
        }

    }
}
