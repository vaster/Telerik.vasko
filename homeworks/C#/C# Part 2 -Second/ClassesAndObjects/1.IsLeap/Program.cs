using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IsLeap
{
    public class Program
    {
        /*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
        */
        static void Main(string[] args)
        {
            int leapYear = 2016;
            int notALeapYear = 1357;

            bool isLeap = DateTime.IsLeapYear(leapYear);
            Console.WriteLine(leapYear + " is leap: " + isLeap);

             isLeap = DateTime.IsLeapYear(notALeapYear);
            Console.WriteLine(notALeapYear + " is leap: " + isLeap);
        }
    }
}
