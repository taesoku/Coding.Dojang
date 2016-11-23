using System.Collections.Generic;

namespace Coding.Dojang.Dojang
{
    public class Question056InsertionSort
    {

        public static void Answer1()
        {

            var inputs = new List<string> { "5", "2", "4", "6", "1", "3" };
            InsertionSort1(inputs);
        }

        public static void InsertionSort1(List<string> inputs)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (int.Parse(inputs[j - 1]) > int.Parse(inputs[j]))
                    {
                        var temp = inputs[j];
                        inputs[j] = inputs[j - 1];
                        inputs[j - 1] = temp;
                    }
                    else break;
                }
            }
        }

        public static void Answer2()
        {
            var inputs = new List<string> { "5", "2", "4", "6", "1", "3" };
            InsertionSort2(inputs);
        }

        public static void InsertionSort2(List<string> inputs)
        {
            for (int i = 1; i < inputs.Count; i++)
                for (int j = i; j > 0; j--)
                    if (int.Parse(inputs[j]) < int.Parse(inputs[j - 1]))
                    {
                        var temp = inputs[j];
                        inputs[j] = inputs[j - 1];
                        inputs[j - 1] = temp;
                    }
                    else break;
        }

    }

}
