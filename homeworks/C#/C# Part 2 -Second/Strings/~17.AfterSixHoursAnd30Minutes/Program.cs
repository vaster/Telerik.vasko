using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.AfterSixHoursAnd30Minutes
{
    /*
     Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
     * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

     */

    internal class Program
    {
        public static DateTime AddTime(DateTime date,int hours,int minutes)
        {
            DateTime newDate = date.AddHours(hours);
            newDate = newDate.AddMinutes(minutes);

            return newDate;
        }

        static void Main(string[] args)
        {
            string date = "8.10.2013 12:22:20";

            int hoursForAddition = 6;
            int minutesForAddition = 3;

            DateTime newDate = Program.AddTime(DateTime.ParseExact(date,"d.M.yyyy h:m:s",null),hoursForAddition,minutesForAddition);

            Console.WriteLine("Original: " + date);
            Console.WriteLine(newDate);
        }
    }
}
