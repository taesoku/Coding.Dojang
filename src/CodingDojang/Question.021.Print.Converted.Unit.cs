using System.Collections;
using System.Collections.Generic;

namespace Coding.Dojang
{
    public class Question021PrintConvertedUnit
    {

        public static void Answer()
        {

            var priceList = new List<double> {1, 2.54, 2.54*10, 72, 96, 20*72, 635*20*72};
            var unitList = new List<string> {"inch", "cm", "mm", "pt", "px", "dxa", "emu"};
            var unitMap = new Hashtable();

            for (int i = 0; i < unitList.Count; i++)
                unitMap[unitList[i]] = priceList[i];

            var output1 = PrintConvertedUnit(unitMap, 10, "cm", "cm");
            var output2 = PrintConvertedUnit(unitMap, 10, "inch", "mm");
            var output3 = PrintConvertedUnit(unitMap, 1024, "px", "pt");
            var output4 = PrintConvertedUnit(unitMap, 768, "px", "inch");
            var output5 = PrintConvertedUnit(unitMap, 9144000, "emu", "inch");
            var output6 = PrintConvertedUnit(unitMap, 12000, "dxa", "px");

        }

        public static string PrintConvertedUnit(Hashtable unitMap, double rate, string unitA, string unitB)
        {
            var convertedValue = 0d;
            var unitValue = 0d;
            if (unitMap.ContainsKey(unitA) && unitMap.ContainsKey(unitB))
            {
                convertedValue = (double) unitMap[unitB];
                unitValue = (double) unitMap[unitA];
            }
            return (int) (rate/unitValue*convertedValue) + " " + unitB;
        }

    }
}