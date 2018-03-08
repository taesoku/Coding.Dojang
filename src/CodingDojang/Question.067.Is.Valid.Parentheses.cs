namespace Coding.Dojang
{
    public static class Question067IsValidParentheses
    {
        public static void Answer()
        {
            var output1 = IsValidParentheses("(()()()())");
            var output2 = IsValidParentheses("(((())))");
            var output3 = IsValidParentheses("(()((())()))");
            var output4 = IsValidParentheses("((((((())");
            var output5 = IsValidParentheses("()))");
            var output6 = IsValidParentheses("(()()(()");
            var output7 = IsValidParentheses("(()))(");
            var output8 = IsValidParentheses("())(()");
        }

        public static bool IsValidParentheses(string input)
        {
            var count = 0;
            foreach (var t in input)
            {
                var curr = t.ToString();
                if (curr == "(") count++;
                else if (curr == ")") count--;
                if (count < 0) return false;
            }
            return count == 0;
        }
    }
}
