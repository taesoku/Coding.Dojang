using System.Collections.Generic;

namespace Coding.Dojang.Dojang
{
    public static class Question029GetIntervene
    {

        public class Node
        {
            public Node Next;
            public int Data;

            public Node(int d)
            {
                Data = d;
            }

            public void AppendToTail(int d)
            {
                var end = new Node(d);
                var n = this;
                while (n.Next != null) n = n.Next;
                n.Next = end;
            }

        }

        public static void Answer()
        {
            var inputs1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            GetIntervene(inputs1);
            var inputs2 = new Node(1);
            for (int i = 1; i < inputs1.Count; i++)
                inputs2.AppendToTail(inputs1[i]);
        }

        public static void Swap(List<int> inputs, int x, int y)
        {
            var temp = inputs[x];
            inputs[x] = inputs[y];
            inputs[y] = temp;
        }

        public static void GetIntervene(List<int> inputs)
        {
            var middle = inputs.Count/2;
            for (int i = 1; i < middle; i++)
                for (int j = 0; j < i; j++)
                    Swap(inputs, middle - i + j*2, middle - i + j*2 + 1);
        }

    }

}
