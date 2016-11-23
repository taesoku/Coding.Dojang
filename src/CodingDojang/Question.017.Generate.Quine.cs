using System;

namespace Coding.Dojang
{
    class Question017GenerateQuine
    {
        public static void Answer()
        {
            GenerateQuine();
        }
        public static void GenerateQuine()
        {
            var quine =
                "class Quine {{\n public static void Quine()" +
                "{{\n string quine = {0}{1}{0};" +
                "Console.Write(quine, (char)34, quine); }} }}\n";
            Console.Write(quine, (char)34, quine);
        }
    }
}
