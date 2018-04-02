using System.Collections.Generic;

namespace Coding.Dojang
{

    public static class Question039MaxDistance
    {

        // time taken: 
        public static void Answer()
        {

            var board1 = new [,] { { "#", "#", "#" }, { "#", ".", "#" }, { "#", "#", "#" } };
            var board2 = new [,] { { "#", "#", "#", "#", "#", "#", "#" }, { "#", ".", "#", ".", "#", "#", "#" }, { "#", ".", "#", ".", "#", "#", "#" }, { "#", ".", "#", ".", "#", ".", "#" }, { "#", ".", ".", ".", ".", ".", "#" }, { "#", "#", "#", "#", "#", "#", "#" } };

            var max = 0;

            for (int i = 0; i < board1.GetLength(0); i++)
            {
                for (int j = 0; j < board1.GetLength(1); j++)
                {
                    var curr = MaxDistance(board1, i, j);
                    if (max < curr) max = curr;
                }
            }

            for (int i = 0; i < board2.GetLength(0); i++)
            {
                for (int j = 0; j < board2.GetLength(1); j++)
                {
                    var curr = MaxDistance(board2, i, j);
                    if (max < curr) max = curr;
                }
            }

        }

        public class Queue
        {
            public List<int> X { get; set; }
            public List<int> Y { get; set; }
            public List<int> Z { get; set; }
            public int Count { get; set; }

            public Queue()
            {
                X = new List<int>();
                Y = new List<int>();
                Z = new List<int>();
                Count = 0;
            }

            public void Enqueue(int x, int y, int z)
            {
                X.Add(x);
                Y.Add(y);
                Z.Add(z);
                Count++;
            }
 
        }

        public static int MaxDistance(string[,] board, int x, int y)
        {
            var count = 0;
            var max = 0;
            var queue = new Queue();
            var shiftX = board.GetLength(0);
            var shiftY = board.GetLength(1);
            if (board[x, y] == "#") return count;
            queue.Enqueue(x, y, 0);
            while (count < queue.Count && (queue.X[count] < shiftX || queue.Y[count] < shiftY))
            {
                var tempX = queue.X[count];
                var tempY = queue.Y[count];
                var tempZ = queue.Z[count];
                board[tempX, tempY] = "#";
                if (tempX > 0 && board[tempX -1, tempY] == ".")
                    queue.Enqueue(tempX - 1, tempY, tempZ + 1);
                if (tempX < shiftX - 1 && board[tempX + 1, tempY] == ".")
                    queue.Enqueue(tempX + 1, tempY, tempZ + 1);
                if (tempY > 0 && board[tempX, tempY - 1] == ".")
                    queue.Enqueue(tempX, tempY - 1, tempZ + 1);
                if (tempY < shiftY - 1 && board[tempX, tempY + 1] == ".")
                    queue.Enqueue(tempX, tempY + 1, tempZ + 1);
                count++;
                if (max < queue.Z[queue.Z.Count - 1]) max = queue.Z[queue.Z.Count - 1];
            }
            return max;
        }

    }
}