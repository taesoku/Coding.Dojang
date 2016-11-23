using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question034FindMines
    {

        // time taken: 00:57:28:86
        public static void Answer()
        {
            string matrix = Console.ReadLine().ToString();
            int row = int.Parse(matrix[0].ToString());
            int column = int.Parse(matrix[2].ToString());
            int[,] mines = new int[row, column];
            for (int i = 0; i < row; i++) FindMines(Console.ReadLine().ToString(), mines, i);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                    if (mines[i, j] >= 10) Console.Write("*");
                    else Console.Write(mines[i, j]);
                Console.Write('\n');
            }
        }

        public static void FindMines(string input, int[,] mines, int i)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == '*')
                {
                    if (i - 1 >= 0) // if current row - 1 exists
                    {
                        mines[i - 1, j]++;
                        if (j - 1 >= 0) mines[i - 1, j - 1]++;
                        if (j + 1 < input.Length) mines[i - 1, j + 1]++;
                    }
                    if (j - 1 >= 0) mines[i, j - 1]++; // current row
                    if (j + 1 < input.Length) mines[i, j + 1]++; 
                    if (i + 1 < mines.GetLength(0)) // if next row exists
                    {
                        mines[i + 1, j]++;
                        if (j - 1 >= 0) mines[i + 1, j - 1]++;
                        if (j + 1 < input.Length) mines[i + 1, j + 1]++;
                    }
                    mines[i, j] += 10; // if there is a mine, mark it as 10
                }
            }
        }

    }

}
