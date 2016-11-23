using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question050FindEuclid
    {

        public class Euclid
        {
            public int X1 { get; set; }
            public int X2 { get; set; }
            public int Y1 { get; set; }
            public int Y2 { get; set; }
            public int R1 { get; set; }
            public int R2 { get; set; }
            public int Q { get; set; }

            public Euclid(int a, int b)
            {
                X1 = 1;
                X2 = 0;
                Y1 = 0;
                Y2 = 1;
                R1 = b;
                R2 = a % b;
                Q = a / b;
            }

            public void UpdateXs(int x1, int x2)
            {
                X1 = x1;
                X2 = x2;
            }
            
            public void UpdateYs(int y1, int y2)
            {
                Y1 = y1;
                Y2 = y2;
            }

            public void UpdateRs(int r1, int r2)
            {
                R1 = r1;
                R2 = r2;
            }

        }

        // time taken: 01:45:26:90
        public static void Answer()
        {
            int dummy = 0;
            List<string> inputs = new List<string>();
            while(dummy == 0)
            {
                string input = Console.ReadLine().ToString();
                if (input.Length == 0) break;
                inputs.Add(input);
            }
            foreach (var input in inputs)
            {
                var splited = input.Split(' ').ToList();
                int first = int.Parse(splited[0]);
                int second = int.Parse(splited[1]);
                Euclid e = new Euclid(first, second);
                FindEuclid(e);
                int remainder = e.R2 != 0 ? e.R2 : e.R1;
                Console.WriteLine(e.X2 + " " + e.Y2 + " " + remainder);
            }
        }

        public static void FindEuclid(Euclid e)
        {
            if (e.R2 == 0) return;
            int x = e.X1 - e.X2 * e.Q;
            int y = e.Y1 - e.Y2 * e.Q;
            e.UpdateXs(e.X2, x);
            e.UpdateYs(e.Y2, y);
            int remainder = e.R1 % e.R2;
            if (remainder == 0) return;
            e.Q = e.R1 / e.R2;
            e.UpdateRs(e.R2, remainder);
            FindEuclid(e);
        }

    }
}
