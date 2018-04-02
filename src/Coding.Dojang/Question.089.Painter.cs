using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Threading.Tasks;

namespace Coding.Dojang.Dojang
{
    public static class Question089Painter
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {

            var x = 5;
            var y = 5;
            var color = 3;
            int[,] board = new int[10, 10]
            {
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,1,0,0,0},
                {0,0,0,0,1,1,0,1,0,0},
                {0,0,1,1,0,0,0,0,1,0},
                {0,1,0,0,0,0,0,0,1,0},
                {0,1,0,0,0,0,0,0,1,0},
                {0,1,0,0,0,0,0,1,0,0},
                {0,0,1,0,0,0,1,0,0,0},
                {0,0,0,1,0,1,1,0,0,0},
                {0,0,0,0,1,0,0,0,0,0}
            };

            DepthFirstSearch(board, x, y, color);
            Display(board);

        }

        private static void DepthFirstSearch(int[,] board, int x, int y, int color)
        {
            if (board[x, y] == 1) board[x, y] = color;
            else return;

            if (x - 1 >= 0) DepthFirstSearch(board, x - 1, y, color);
            if (x + 1 < board.Length) DepthFirstSearch(board, x + 1, y, color);
            if (y - 1 >= 0) DepthFirstSearch(board, x, y - 1, color);
            if (y + 1 < board.Length) DepthFirstSearch(board, x, y + 1, color);
        }

        private static void Display(int[,] board)
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                    Console.Write("{0}\t", board[x, y]);
                Console.WriteLine();
            }
        }
        
    }
}
