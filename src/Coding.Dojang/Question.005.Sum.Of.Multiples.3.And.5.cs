using System;
 
namespace Coding.Dojang
{
    public static class Question005SumOfMultiples3And5
    {
        // time taken: 00:09:14:41
        public static void Answer()
        {
            Console.Write("Please type the maximum number: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfMultiples3And5(n)); // 233168
        }

        public static int SumOfMultiples3And5(int n)
        {
            var sum = 0;
            for (int i = 3; i < n; i++)
                sum += i % 3 == 0 || i % 5 == 0 ? i : 0;
            return sum;
        }

    }
}
