using System.Linq;

namespace Coding.Dojang
{
    public static class Question097CompareVersions
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            var output1 = CompareVersions("0.0.2", "0.0.1");
            var output2 = CompareVersions("1.0.10", "1.0.3");
            var output3 = CompareVersions("1.2.0", "1.1.99");
            var output4 = CompareVersions("1.1", "1.0.1");
        }

        public static string CompareVersions(string input1, string input2)
        {
            var split1 = input1.Split('.').ToList();
            var split2 = input2.Split('.').ToList();
            while (split1.Count() > 0 && split2.Count() > 0)
            {
                if (int.Parse(split1.First()) > int.Parse(split2.First())) return input1;
                if (int.Parse(split1.First()) > int.Parse(split2.First())) return input1;
                split1.RemoveAt(0);
                split2.RemoveAt(0);
            }
            return split1.Count() > split2.Count() ? input1 : input2;
        }

    }
}