using System;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question072TicTacToe
    {

        const int N = 3;
        public static void Answer1()
        {

            int[,] board = new int[N, N];

            var win = false;
            var n = 1;
            while (!win)
            {
                Console.Write("Please type a number: ");
                var input = int.Parse(Console.ReadLine().ToString());
                var row = (input - 1) / N;
                var column = (input - 1) % N;
                if (board[row, column] == 0)
                {
                    board[row, column] = n;
                    win = CheckTicTacToe(board, row, column, n);
                    if (!win) n *= -1;
                }        
            }
            if (n == 1) Console.WriteLine("Player A won.");
            else Console.WriteLine("Player B won.");
        }
        public static bool CheckTicTacToe(int[,] board, int x, int y, int n)
        {

            var win = true;
            for (int i = 0; i < N; i++)
                if (board[x, i] != n) win = false;

            if (win) return true;

            win = true;
            for (int i = 0; i < N; i++)
                if (board[i, y] != n) win = false;

            if (win) return true;

            if (board[1, 1] == n)
            {
                if (board[0, 0] == n && board[2, 2] == n)
                    return true;
                if (board[2, 0] == n && board[0, 2] == n)
                    return true;
            }

            return false;

        }

        public static void Answer2()
        {
            TicTacToe(new string[3, 3]);
        }

        public static void TicTacToe(string[,] board)
        {
            var complete = false;
            var turn = true;
            while (!complete)
            {
                var n = int.Parse(Console.ReadLine().ToString()) - 1;
                var row = n / 3;
                var column = n % 3;
                if (board[row, column] == null) board[row, column] = turn ? "O" : "X";
                else Console.WriteLine("Error Occured");
                complete = CheckBoard(board, row, column, turn ? "O" : "X");
                if (!complete) turn = !turn;
            }
        }

        public static bool CheckBoard(string[,] board, int x, int y, string mark)
        {
            var rowCount = 0;
            var columnCount = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[x, i] == mark) rowCount++;
                if (board[i, y] == mark) columnCount++;
            }
            if (rowCount == 3 || columnCount == 3) return true;
            if (board[1, 1] == mark)
            {
                if (board[0, 0] == mark && board[2, 2] == mark) return true;
                if (board[2, 0] == mark && board[0, 2] == mark) return true;
            }
            return false;
        }

    }
}
