using System;
using System.Diagnostics.Eventing.Reader;

namespace Coding.Dojang
{

    public class Question058IsOneEditApart
    {

        // time taken: 00:20:33:22
        public static void Answer()
        {
            Console.WriteLine(IsOneEditApart("cat", "dog"));
            Console.WriteLine(IsOneEditApart("cat", "cats"));
            Console.WriteLine(IsOneEditApart("cat", "cut"));
            Console.WriteLine(IsOneEditApart("cat", "cast"));
            Console.WriteLine(IsOneEditApart("cat", "at"));
            Console.WriteLine(IsOneEditApart("cat", "acts"));
        }

        public static bool IsOneEditApart(string a, string b)
        {
            var count = 0;
            var large = a.Length > b.Length ? a : b;
            var small = a.Length > b.Length ? b : a;
            if (large.Length == small.Length)
            {
                for (int i = 0; i < large.Length; i++)
                    if (large[i] != small[i] && ++count > 1)
                        return false;
            }
            else if (large.Length > small.Length)
            {
                var i = 0;
                while (i < small.Length)
                {
                    if (large[i + count] != small[i])
                    {
                        if (++count > 1) return false;
                    }
                    else i++;
                }
            }
            else return false;
            return true;
        }

    }

}
