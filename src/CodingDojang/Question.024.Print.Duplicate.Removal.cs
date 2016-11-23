using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question024PrintDuplicateRemoval
    {

        public static void Answer()
        {
            var inputs = new List<string>
            {"이유덕","이재영","권종표","이재영","박민호","강상희","이재영","김지완","최승혁","이성연","박영서","박민호","전경헌","송정환","김재성","이유덕","전경헌"};
            var outputs = PrintDuplicateRemoval(inputs);
        }

        public static List<string> PrintDuplicateRemoval(List<string> inputs)
        {
            var kim = inputs.Count(i => i.First() == '김');
            var lee = inputs.Count(i => i.First() == '이');
            var ljy = inputs.Count(i => i == "이재영");
            var outputs = inputs.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).ToList();
            return outputs;
        }

    }
}