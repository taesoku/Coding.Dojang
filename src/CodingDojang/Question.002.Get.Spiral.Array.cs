using System;

namespace Coding.Dojang
{
    public static class Question002GetSpiralArray
    {

        public static void Answer()
        {
            var output = GetSpiralArray(6, 4);
            for (int i = 0; i < output.GetLength(0); i++)
            {
                for (int j = 0; j < output.GetLength(1); j++)
                {
                    Console.Write(output[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            //Console.WriteLine("\n");
            //Rotate(output, 4);
            //for (int i = 0; i < output.GetLength(0); i++)
            //{
            //    for (int j = 0; j < output.GetLength(1); j++)
            //    {
            //        Console.Write(output[i, j] + " ");
            //    }
            //    Console.WriteLine("\n");
            //}
        }


        public static void Rotate(int[,] inputs, int n)
        {
            for (int i = 0; i < n / 2; ++i)
            {
                var first = i;
                var last = n - 1 - i;
                for (int j = first; j < last; ++j)
                {
                    var offset = j - first;
                    var top = inputs[first,j];
                    inputs[first,j] = inputs[last - offset,first];
                    inputs[last - offset,first] = inputs[last,last - offset];
                    inputs[last,last - offset] = inputs[j,last];
                    inputs[j,last] = top;
                }
            }
        }

        public static int[,] GetSpiralArray(int m, int n)
        {
            var count = 0;
            var i = 0;
            var j = 0;
            var outputs = new int[m, n];
            var shiftX = m - 1;
            var shiftY = n;
            var temp = n;
            var value = 0;
            while (temp <= outputs.Length)
            {
                outputs[i, j] = value;
                value++;
                if (temp == value)
                {
                    count++;
                    if (count%2 == 0)
                    {
                        shiftX--;
                        if (shiftY == 0) break;
                        temp += shiftY;
                    }
                    else
                    {
                        shiftY--;
                        if (shiftX == 0) break;
                        temp += shiftX;
                    }
                }
                if (count%4 == 0) j++;
                else if (count%4 == 1) i++;
                else if (count%4 == 2) j--;
                else i--;
            }
            return outputs;
        }

    }
}

