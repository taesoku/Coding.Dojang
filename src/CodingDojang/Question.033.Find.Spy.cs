using System.Collections.Generic;
using System.Linq;

namespace Coding.Dojang
{
    public static class Question033FindSpy
    {

        public class Spy
        {
            public List<int> Outputs { get; set; }
            public bool IsFriend { get; set; }
            public Spy(List<int> outputs, bool isFriend)
            {
                Outputs = outputs;
                IsFriend = isFriend;
            }
        }

        public static void Answer()
        {
            var inputs1 = new List<string>();
            inputs1.Add("1 2 f");
            inputs1.Add("2 3 e");
            inputs1.Add("1 3 f");
            var outputs1 = FindSpy(inputs1);
            var inputs2 = new List<string>();
            inputs2.Add("1 2 f");
            inputs2.Add("3 4 e");
            inputs2.Add("4 5 f");
            inputs2.Add("2 4 e");
            inputs2.Add("1 3 e");
            inputs2.Add("1 4 e");
            inputs2.Add("5 3 e");
            var outputs2 = FindSpy(inputs2);
        }

        public static int FindSpy(List<string> inputs)
        {
            var spies = new List<Spy>();
            for (int i = 0; i < inputs.Count; i++)
            {
                var split = inputs[i].Split(' ').ToList();
                var x = int.Parse(split[0]);
                var y = int.Parse(split[1]);
                var isFriend = split.Last() == "f";
                if (spies.Any(s => s.Outputs.Contains(x) || s.Outputs.Contains(y)))
                {
                    var curr = spies.FirstOrDefault(s => s.Outputs.Contains(x) && s.Outputs.Contains(y));
                    if (curr != null)
                    {
                        if (curr.IsFriend != isFriend) return i + 1;
                        continue;
                    }
                    var temps = spies.Where(s => s.Outputs.Contains(x) || s.Outputs.Contains(y)).ToList();
                    for (int j = 0; j < temps.Count; j++)
                    {
                        var a = temps[j].Outputs.First(o => o != x && o != y);
                        var b = temps[j].Outputs.First(o => o == x || o == y) != x ? x : y;
                        if (spies.Any(s => s.Outputs.Contains(a) && s.Outputs.Contains(b) && s.IsFriend != isFriend))
                            return i + 1;
                        spies.Add(new Spy(new List<int> { a, b }, isFriend));
                    }
                    continue;

                }
                spies.Add(new Spy(new List<int> { x, y }, isFriend));
            }
            return 0;
        }

    }

}
