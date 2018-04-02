using System;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public static class Question025PrintPotsOfGoldGame
    {

        // time taken 2:17:24,81

        public static void Answer()
        {

            Console.Write("Please type the number of pots: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please type the maximum golds on each pot: ");
            int gold = int.Parse(Console.ReadLine());

            List<int> inputs = InitializeList(n, gold + 1);
            for (int i = 0; i < inputs.Count; i++)
                Console.Write(inputs[i] + " ");
            Console.Write("\n");
            Node<int> pots = new Node<int>(0);
            InitializeNode(inputs, pots, 0, inputs.Count - 1);
            PrintPotsOfGoldGame(pots);

        }

        public class Node<T> where T : IComparable
        {
            private T data;
            public Node<T> Left, Right;
            public Node(T item)
            {
                data = item;
                Left = Right = null;
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }

        public static List<int> InitializeList(int n, int gold)
        {
            var inputs = new List<int>();
            var random = new Random();
            for (int i = 0; i < n; i++) inputs.Add(random.Next(gold + 1));
            return inputs;
        }

        public static void InitializeNode(List<int> inputs, Node<int> pots, int left, int right)
        {
            if (left > right) return;
            pots.Left = new Node<int>(inputs[left]);
            pots.Right = new Node<int>(inputs[right]);
            InitializeNode(inputs, pots.Left, left + 1, right);
            InitializeNode(inputs, pots.Right, left, right - 1);
        }

        public static void PrintPotsOfGoldGame(Node<int> pots, int playerA = 0, int playerB = 0, bool turn = true)
        {
            if (pots.Left == null && pots.Right == null)
            {
                if (playerA > playerB) Console.WriteLine("Player A won the game.");
                else Console.WriteLine("Player B won the game.");
                return;
            }
            var left = Optimize(pots.Left);
            var right = Optimize(pots.Right);
            if (turn)
            {
                playerA += left > right ? pots.Left.Data : pots.Right.Data;
                if (left > right)
                    Console.WriteLine("Player A has taken left. A has " + playerA + " golds.");
                else Console.WriteLine("Player A has taken right. A has " + playerA + " golds.");
            }
            else
            {
                playerB += left > right ? pots.Left.Data : pots.Right.Data;
                if (left > right)
                    Console.WriteLine("Player B has taken left. B has " + playerB + " golds.");
                else Console.WriteLine("Player B has taken right. B has " + playerB + " golds.");
            }
            PrintPotsOfGoldGame(left > right ? pots.Left : pots.Right, playerA, playerB, !turn);
        }

        public static double Optimize(Node<int> pots, int a = 0, int b = 0, double win = 0, bool turn = true)
        {
            if (turn) a += pots.Data;
            else b += pots.Data;
            if (pots.Left == null && pots.Right == null) return a > b ? 1 : 0;
            win += Optimize(pots.Left, a, b, win, !turn);
            win += Optimize(pots.Right, a, b, win, !turn);
            return win;
        }

    }
}