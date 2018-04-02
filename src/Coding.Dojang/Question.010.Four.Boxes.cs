using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question010FourBoxes
    {

        // time taken: 00:22:41:67
        public static void Answer()
        {
            var inputs = new List<Rectangle>();
            for(int i = 0; i < 4; i++)
            {
                var inputString = Console.ReadLine().Split(' ').ToList();
                inputs.Add(new Rectangle(inputString[0], inputString[1], inputString[2], inputString[3]));
            }
            FourBoxes(inputs);
        }

        public class Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Coordinate(string x, string y)
            {
                X = int.Parse(x);
                Y = int.Parse(y);
            }
            
        }
        
        public class Rectangle
        {
            public Coordinate Bottom { get; set; }
            public Coordinate Top { get; set; }

            public Rectangle(string x1, string y1, string x2, string y2)
            {
                Bottom = new Coordinate(x1, y1);
                Top = new Coordinate(x2, y2);
            }

        }

        public static void FourBoxes(List<Rectangle> inputs)
        {
            var area = 0;
            var maxX = inputs.Max(i => i.Top.X);
            var maxY = inputs.Max(i => i.Top.Y);
            for(int i = 0; i < maxX; i++)
                for(int j = 0; j < maxY; j++)
                    if(ValidInFourBoxes(inputs, i, j)) area++;
            Console.WriteLine(area);
        }

        public static bool ValidInFourBoxes(List<Rectangle> inputs, int x, int y)
        {
            foreach (var input in inputs)
                if (input.Bottom.X <= x && input.Top.X > x && input.Bottom.Y <= y && input.Top.Y > y) return true;
            return false;
        }

    }
}
