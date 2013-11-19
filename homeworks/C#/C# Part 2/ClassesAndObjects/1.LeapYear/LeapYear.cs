using System;
using System.Collections.Generic;



class LeapYear
{
    static void Main(string[] args)
    {
        int year;
        Console.Write("Enter year:");
        year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Yes, {0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("Sorry, {0} it isn't.",year);
        }
    }
}

