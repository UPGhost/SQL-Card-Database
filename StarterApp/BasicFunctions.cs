using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterApp
{
    public static class BasicFunctions
    {
        public static string[] SingleDigitHours { get; } = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            //Checks if it's late at Night and calls user out for it
            public static void LateNightCheck(System.DateTime theDate, string[] LateHoursArray)
        {
            string SingleDigitHour = "";
            bool NormalHours = true;

            for (int i = 0; i < LateHoursArray.Length; i++)
            {
                if (theDate.Hour.ToString() == LateHoursArray[i])
                {
                    //If Single Digit Hour, add a 0 at start, aesthetic reason
                    for (int x = 0; x < SingleDigitHours.Length; x++)
                    {
                        if (SingleDigitHours[x] == LateHoursArray[i])
                        {
                            SingleDigitHour = "0";
                        }
                    }

                    Console.WriteLine("{0}{1}:{2}? Isn't it getting a bit late for you to be up?", SingleDigitHour, theDate.Hour.ToString(), theDate.Minute.ToString());
                    NormalHours = false;
                }
            }

            if (NormalHours == true)
            {
                Console.WriteLine("{0}{1}:{2}? Isn't it getting a bit late for you to be up?", SingleDigitHour, theDate.Hour.ToString(), theDate.Minute.ToString());
            }
        }
    }
}
