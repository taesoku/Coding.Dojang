using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Threading.Tasks;

namespace Coding.Dojang
{

    public static class Question038RandomWalk
    {

        // time taken: 
        public static void Answer()
        {
            string inputLine = Console.ReadLine().ToString();
            inputLine = inputLine.Replace(" ", string.Empty);
            List<string> input = inputLine.Split(',').ToList();
            if (input.Count != 3)
                return;

            int[,] matrix = new int[int.Parse(input[0]), int.Parse(input[1])];

            // initial position
            int row = int.Parse(input[2].First().ToString());
            int column = int.Parse(input[2].Last().ToString());
            int count = 0;

            matrix[row, column]++;
            count = RandomWalk(matrix, row, column, row, column, count);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.Write('\n');

            }

            Console.WriteLine(count);

        }

        public static bool CheckBoundary(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == 0)
                        return false;
            return true;
        }

        public static int RandomWalk(int[,] matrix, int row, int column, int prevRow, int prevColumn, int count)
        {

            int maxRow = matrix.GetLength(0);
            int maxColumn = matrix.GetLength(1);

            List<string> nextMove = new List<string>();

            for (int i = row - 1; i <= row + 1; i++)
            {

                if (i < 0 || i >= maxRow)
                    continue;

                for (int j = column - 1; j <= column + 1; j++)
                {

                    if (j < 0 || j >= maxColumn)
                        continue;

                    if ((i == row && j == column) || (i == prevRow && j == prevColumn))
                        continue;

                    nextMove.Add(i + "," + j);
                
                }

            }

            nextMove.RemoveAll(nm => nm.Length == 0);

            Random random = new Random();
            int position = random.Next(0, nextMove.Count);

            prevRow = row;
            prevColumn = column;    

            row = int.Parse(nextMove[position].First().ToString());
            column = int.Parse(nextMove[position].Last().ToString());

            nextMove = new List<string>();

            matrix[row, column]++;
            count++;

            if (!CheckBoundary(matrix))
                count = RandomWalk(matrix, row, column, prevRow, prevColumn, count);

            return count;

        }


    }

}
