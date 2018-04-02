using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Coding.Dojang
{
    class Question018GetFileDirectories
    {
        public static void Answer()
        {
            var outputs = GetFileDirectories("C:\\Users\\benjamin\\downloads");
        }

        public static List<string> GetFileDirectories(string input)
        {
            var subdirectories = Directory.GetDirectories(input, "*", SearchOption.AllDirectories);
            var outputs = new List<string>();
            foreach (var directory in from directories in subdirectories select directories)
                foreach (var file in new DirectoryInfo(directory).GetFiles("*.txt"))
                    if (File.ReadAllText(file.FullName).Contains("LIFE IS TOO SHORT"))
                        outputs.Add(file.FullName);
            foreach (var file in new DirectoryInfo(input).GetFiles("*.txt"))
                if (File.ReadAllText(file.FullName).Contains("LIFE IS TOO SHORT"))
                    outputs.Add(file.FullName);
            return outputs;
        }

    }
}
