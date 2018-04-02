namespace Coding.Dojang
{
    public static class Question081ValidateLawnmower
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            
            var input1 = new int[3, 3] { { 2, 1, 2 }, { 1, 1, 1 }, { 2, 1, 2 } };
            var output1 = ValidateLawnmower(input1);
            var input2 = new int[5, 5] { { 2, 2, 2, 2, 2 }, { 2, 1, 1, 1, 2 }, { 2, 1, 2, 1, 2 }, {2, 1, 1, 1, 2}, {2, 2, 2, 2, 2} };
            var output2 = ValidateLawnmower(input2);
            var input3 = new int[1, 3] { { 1, 2, 1 } };
            var output3 = ValidateLawnmower(input3);

            var input4 = new int[3, 3] { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            var output4 = ValidateLawnmower(input4);
            var input5 = new int[3, 3] { { 2, 2, 2 }, { 1, 1, 1 }, { 2, 1, 2 } };
            var output5 = ValidateLawnmower(input5);
            var input6 = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            var output6 = ValidateLawnmower(input6);
            var input7 = new int[3, 3] { { 3, 2, 1 }, { 3, 2, 1 }, { 3, 2, 1 } };
            var output7 = ValidateLawnmower(input7);
            var input8 = new int[7, 7] { { 2, 2, 2, 2, 2, 3, 2 }, { 2, 1, 1, 1, 2, 3, 1 }, { 2, 1, 2, 1, 2, 4, 2 }, {2, 1, 1, 3, 2, 4, 2}, {2, 2, 2, 2, 2, 4, 2}, {2, 2, 2, 2, 2, 4, 2}, {2, 2, 2, 2, 2, 4, 2} };
            var output8 = ValidateLawnmower(input8);
            var input9 = new int[20, 10] { { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 15, 15, 15, 15, 15, 15, 15, 10, 15, 15 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, 
            { 20, 30, 30, 30, 30, 30, 30, 10, 30, 30 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 25, 25, 25, 25, 25, 25, 10, 25, 25 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 25, 25, 25, 25, 25, 25, 10, 25, 25 }, 
            { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 15, 15, 15, 15, 15, 15, 15, 10, 15, 15 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, { 20, 30, 30, 30, 30, 30, 30, 10, 30, 30 }, 
            { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 50, 40, 50, 40, 50, 50, 10, 35, 50 }, { 20, 40, 40, 40, 40, 40, 40, 10, 40, 40 } };
            var output9 = ValidateLawnmower(input9);

        }

        public static bool ValidateLawnmower(int[,] input)
        {
            for(int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    var curr = input[i, j];
                    for (int k = 0; k < input.GetLength(1); k++)
                    {
                        if (input[i, k] <= curr) continue;
                        for (int l = 0; l < input.GetLength(0); l++)
                            if (input[l, j] > curr) return false;
                    }
                }
            }
            return true;
        }

    }
}
