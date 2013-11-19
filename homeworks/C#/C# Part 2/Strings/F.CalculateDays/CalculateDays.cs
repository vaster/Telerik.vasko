using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateDays
{
    static void Main(string[] args)
    {

        DateTime dateOne = new DateTime();
        DateTime dateTwo = new DateTime();
        TimeSpan diff = new TimeSpan();

        string firstDate;
        string secondDate;
        
        Console.WriteLine("Format:day.month.year");
        Console.Write("Enter first date:");
        firstDate = Console.ReadLine();

        Console.Write("Enter second date:");
        secondDate = Console.ReadLine();



        dateOne = DateTime.Parse(firstDate);
        dateTwo = DateTime.Parse(secondDate);

        if (dateOne > dateTwo)
        {
            diff = dateOne - dateTwo;
        }
        // Console.WriteLine(dateOne.Day);
        else
        {
            diff = dateTwo - dateOne;
        }
       
            dateOne.AddDays(1);
            //counter++;
        

        Console.WriteLine("{0} days",diff.Days);
    }
}

