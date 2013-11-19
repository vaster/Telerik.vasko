using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CalculateDayDiffFromTwoDates
{
    /*
     Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
     * Example:
     * 
     * Enter the first date: 27.02.2006
        Enter the second date: 3.03.2004
        Distance: 4 days
     */

    internal class Program
    {
        public static TimeSpan CalculateDayDifference(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan difference =secondDate - firstDate;

            return difference;
        }

        static void Main(string[] args)
        {
            string firstDate = "27.02.2006";
            string secondDate = "3.03.2004";

            TimeSpan diff = Program.CalculateDayDifference(DateTime.ParseExact(firstDate, "d.M.yyyy", null), DateTime.ParseExact(secondDate, "d.M.yyyy", null));

            Console.WriteLine("Days between {0} and {1}",firstDate,secondDate);
            Console.WriteLine(Math.Abs(diff.Days));
        }
    }
}
