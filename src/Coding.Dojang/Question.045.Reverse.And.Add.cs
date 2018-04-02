using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public class Question045ReverseAndAdd
    {

        public class Palindrome
        {

            public string Answer { get; set; }
            public int Count { get; set; }

            public Palindrome(string answer)
            {
                Answer = answer;
                Count = 0;
            }

            public void Increment()
            {
                Count++;
            }

        }

        // time taken: 00:39:09:95
        public static void Answer()
        {

            var number = int.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine("The maxmium number of inputs is 100.");
                return;
            }

            var temp = Console.ReadLine();

            var inputs = new List<Palindrome>(number);

            while (temp.Length > 0)
            {
                var input = new Palindrome(temp);
                inputs.Add(input);
                temp = Console.ReadLine();
            }

            if (inputs.Count != number)
            {
                Console.WriteLine
                    ("The number of inputs and the specified number of inputs do not match");
                return;
            }

            foreach (var input in inputs)
            {
                ReverseAndAdd(input);
                if (input.Answer.Length > 10)
                    Console.WriteLine(input.Answer);
                else Console.WriteLine(input.Count + " " + input.Answer);
            }

        }

        public static void ReverseAndAdd(Palindrome input)
        {

            var reverse = Reverse(input.Answer);

            // check if palindrome is found
            if (input.Answer == reverse) return;

            // check if the number of times excuted
            if (input.Count >= 1000)
            {
                input.Answer = "Maximum counts reached. Excution halted.";
                return;
            }

            var add = Add(input.Answer, reverse);

            // index out of range
            if (add > 4294967295)
            {
                input.Answer = "Maximum palindrome reached. Excution halted.";
                return;
            }

            input.Answer = add.ToString();
            input.Increment();

            ReverseAndAdd(input);

        }

        public static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        public static ulong Add(string input, string reverse)
        {
            return ulong.Parse(input) + ulong.Parse(reverse);
        }

    }
}
