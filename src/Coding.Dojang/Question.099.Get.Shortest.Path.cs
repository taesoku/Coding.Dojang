using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question099GetShortestPath
    {

        public class Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }
            public decimal Distance { get; set; }
            public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void UpdateDistance(int x, int y)
            {
                var diffX = Math.Abs(X - x);
                var diffY = Math.Abs(Y - y);
                Distance = (decimal)Math.Sqrt((diffX * diffX + diffY * diffY));
            }
        }

        public static void Answer()
        {

        }

        public static decimal GetShortestPath(List<Coordinate> inputs, int i = 0, decimal sum = 0)
        {
            if (i == inputs.Count) return sum;
            inputs[i + 1].UpdateDistance(inputs[i].X, inputs[i].Y);
            return GetShortestPath(inputs, i + 1, sum + inputs[i + 1].Distance);
        }


    }
}