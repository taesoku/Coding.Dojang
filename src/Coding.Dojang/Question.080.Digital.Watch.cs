using System;
using System.Collections.Generic;
 
 
using System.Threading.Tasks;

namespace Coding.Dojang
{
    public static class Question080DigitalWatch
    {

        // time taken: 00:05:27:21
        public static void Answer()
        {
            var output = DigitalWatch("3");
            //var input = Console.ReadLine().ToString();
            
            //var countHours = 0;
            //var countMinutes = 0;

            //// calculating hours
            //for(int i = 0; i < 24; i++)
            //    if(i.ToString().Contains(input))
            //        countHours++;

            //for(int i = 0; i < 60; i++)
            //    if (i.ToString().Contains(input))
            //        countMinutes++;

            //var totalSeconds = (countHours * 60 * 60) + ((24 - countHours) * countMinutes * 60);

            //Console.WriteLine(totalSeconds);

        }


        public static int DigitalWatch(string n)
        {
            var countHours = 0;
            var countMinutes = 0;

            for (int i = 1; i <= 60; i++)
            {
                if (i <= 24) countHours += i.ToString().Contains(n) ? 1 : 0;
                countMinutes += i.ToString().Contains(n) ? 1 : 0;
            }
            return countHours * 60 * 60 + (24 - countHours) * countMinutes * 60;
        }

    }
}
