using System;
using System.Collections.Generic;
using System.Linq;
 
 

namespace Coding.Dojang
{
    class Question014ListTurn
    {

        // time taken: 00:25:41:71
        public static void Answer()
        {
            List<string> list = new List<string>();

            list = Console.ReadLine().ToString().Split(' ').ToList();

            int turn = int.Parse(list[0]);

            list.RemoveAt(0);

            list = ListTurn(list, turn);

            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + ' ');

            Console.Write('\n');

        }

        public static List<string> ListTurn(List<string> list, int turn)
        {
            if (turn < 0)
            {
                int remainder = turn % list.Count;

                for (int i = 0; i > remainder; i--)
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
            }
            else
            {
                int remainder = turn % list.Count;

                for (int i = 0; i < remainder; i++)
                {
                    list.Insert(0, list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }

            }

            return list;
        }


    }
}
