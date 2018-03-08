namespace Coding.Dojang
{
    public static class Question067IsValidParentheses
    {
        public static void Answer()
        {
            var output1 = ValidateParentheses("(()()()())");
            var output2 = ValidateParentheses("(((())))");
            var output3 = ValidateParentheses("(()((())()))");
            var output4 = ValidateParentheses("((((((())");
            var output5 = ValidateParentheses("()))");
            var output6 = ValidateParentheses("(()()(()");
            var output7 = ValidateParentheses("(()))(");
            var output8 = ValidateParentheses("())(()");
        }

        public static bool ValidateParentheses(string input)
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
