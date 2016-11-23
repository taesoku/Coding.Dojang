using System;
using System.Collections.Generic;
using System.Linq;
 
using System.Threading.Tasks;

namespace Coding.Dojang
{
    public class Question047CheckTheCheck
    {

        public class Chess
        {

            public string[] Matrix { get; set; }
            public int BlackKingRow { get; set; }
            public int BlackKingColumn { get; set; }
            public int WhiteKingRow { get; set; }
            public int WhiteKingColumn { get; set; }

            public Chess()
            {
                Matrix = new string[8];
                BlackKingRow = -1;
                BlackKingColumn = -1;
                WhiteKingRow = -1;
                WhiteKingColumn = -1;
            }

        }

        // time taken: 01:33:17:89
        public static void Answer()
        {

            List<Chess> games = new List<Chess>();

            int dummy = 0;

            while(dummy == 0 || Console.ReadLine().ToString() == "\n")
            {

                Chess chess = new Chess();

                for (int i = 0; i < 8; i++)
                {

                    chess.Matrix[i] = Console.ReadLine().ToString();

                    if (chess.Matrix[i].Contains('K'))
                    {
                        chess.WhiteKingRow = i;
                        chess.WhiteKingColumn = chess.Matrix[i].IndexOf('K');
                    }

                    if (chess.Matrix[i].Contains('k'))
                    {
                        chess.BlackKingRow = i;
                        chess.BlackKingColumn = chess.Matrix[i].IndexOf('k');
                    }

                }

                var count = chess.Matrix.Count(c => c == "........");

                if (count < 8)
                    games.Add(chess);
                else
                    break;

            }

            for (int i = 0; i < games.Count; i++)

                if (IsBlackInAttack(games[i], 
                    games[i].WhiteKingRow, games[i].WhiteKingColumn))
                    Console.WriteLine("Game  #" + i + ": white king is in check");
                else if (IsWhiteInAttack(games[i], 
                    games[i].BlackKingRow, games[i].BlackKingColumn))
                    Console.WriteLine("Game  #" + i + ": black king is in check");

        }

        public static bool IsBlackInAttack(Chess chess, int row, int column)
        {

            if (CheckKing(chess, row, column))
                return true;

            if (CheckDiagonal(chess, row, column, new List<string> { "q", "b" }))
                return true;

            if (CheckHorizontalVertical(chess, row, column, new List<string> { "q", "r" }))
                return true;

            if (CheckKnight(chess, row, column, "n"))
                return true;

            if (CheckPawn(chess, row, column, "p"))
                return true;

            return false;

        }

        public static bool IsWhiteInAttack(Chess chess, int row, int column)
        {

            if (CheckKing(chess, row, column))
                return true;

            if (CheckDiagonal(chess, row, column, new List<string>{ "Q", "B" }))
                return true;

            if (CheckHorizontalVertical(chess, row, column, new List<string> { "Q", "R" }))
                return true;

            if (CheckKnight(chess, row, column, "N"))
                return true;

            if (CheckPawn(chess, row, column, "P"))
                return true;

            return false;

        }

        public static bool CheckKing(Chess chess, int row, int column)
        {
            
            for (int i = row - 1; i >= row + 1; i++)
                for (int j = row - 1; j >= row + 1; j++)
                    if (i >= 0 && j >= 0)
                    {

                        if (i == row && j == column)
                            continue;

                        if (chess.Matrix[i][j].ToString().ToLower() == "k")
                            return true;

                    }

            return false;


        }

        public static bool CheckDiagonal(Chess chess, 
            int row, int column, List<string> letters)
        {

            int i = row - 1, j = column - 1;

            while (i >= 0 && j >= 0)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i--; j--;
            }

            i = row + 1; j = column + 1;

            while (i < 8 && j < 8)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i++; j++;
            }

            i = row + 1; j = column - 1;

            while (i < 8 && j >= 0)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i++; j--;
            }

            i = row - 1; j = column + 1;

            while (i >= 0 && j < 8)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i--; j++;
            }

            return false;

        }

        public static bool CheckHorizontalVertical(Chess chess, 
            int row, int column, List<string> letters)
        {

            int i = row - 1, j = column;

            while(i >= 0)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i--;
            }

            i = row + 1;

            while (i < 8)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                i++;
            }

            i = row; j = column - 1;

            while (j >= 0)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                j--;
            }

            j = column + 1;

            while (j < 8)
            {
                if (letters.Any(l => l == chess.Matrix[i][j].ToString()))
                    return true;
                if (chess.Matrix[i][j].ToString() != ".")
                    break;
                j++;
            }

            return false;

        }

        public static bool CheckKnight(Chess chess, int row, int column, string knight)
        {

            if (row - 2 >= 0 && column - 1 >= 0)
                if (chess.Matrix[row - 2][column - 1].ToString() == knight)
                    return true;

            if (row - 1 >= 0 && column - 2 >= 0)
                if (chess.Matrix[row - 1][column - 2].ToString() == knight)
                    return true;

            if (row - 2 >= 0 && column + 1 < 8)
                if (chess.Matrix[row - 2][column + 1].ToString() == knight)
                    return true;

            if (row - 1 >= 0 && column + 2 < 8)
                if (chess.Matrix[row - 1][column + 2].ToString() == knight)
                    return true;

            if (row + 2 < 8 && column - 1 >= 0)
                if (chess.Matrix[row + 2][column - 1].ToString() == knight)
                    return true;

            if (row + 1 < 8 && column - 2 >= 0)
                if (chess.Matrix[row + 1][column - 2].ToString() == knight)
                    return true;

            if (row + 2 < 8 && column + 1 < 8)
                if (chess.Matrix[row + 2][column + 1].ToString() == knight)
                    return true;

            if (row + 1 < 8 && column + 2 < 8)
                if (chess.Matrix[row + 1][column + 2].ToString() == knight)
                    return true;

            return false;

        }

        public static bool CheckPawn(Chess chess, int row, int column, string pawn, bool white = true)
        {

            int i = white ? row + 1 : row - 1;

            if (i >= 8)
                return false;

            if (column - 1 >= 0)
                if (chess.Matrix[i][column - 1].ToString() == pawn)
                    return true;

            if (column + 1 < 8)
                if (chess.Matrix[i][column + 1].ToString() == pawn)
                    return true;

            return false;

        }

    }
}
