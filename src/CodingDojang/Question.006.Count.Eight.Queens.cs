namespace Coding.Dojang
{
    public static class Question006CountEightQueens
    {

        const int N = 8;

        public static void Answer()
        {
            var count = CountEightQueens(new bool[N,N]);
        }

        public static int CountEightQueens(bool[,] board, int row = 0, int count = 0)
        {
            for (int j = 0; j < N; j++)
            {
                if (CheckBoard(board, row, j))
                {
                    if (row < 7)
                    {
                        board[row, j] = true;
                        count = CountEightQueens(board, row + 1, count);
                        board[row, j] = false;
                    }
                    else return ++count;
                }
            }
            return count;
        }

        public static bool CheckBoard(bool[,] board, int x, int y)
        {
            for (int i = -N; i < N; i++)
            {
                if (i >= 0 && (board[x, i] || board[i, y])) return false;
                if (x + i >= 0 && x + i < N && i != 0)
                {
                    if (y + i >= 0 && y + i < N) if (board[x + i, y + i]) return false;
                    if (y - i >= 0 && y - i < N) if (board[x + i, y - i]) return false;
                }
            }
            return true;
        }

    }
}
