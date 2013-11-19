using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class After6hoursAnd30minutes
{
    static void Main(string[] args)
    {
        string date;
        string time;
        string dateAndTime;

        DateTime isDate = new DateTime();
        

        Console.WriteLine("Format:day.month.year.");

        Console.Write("Enter date:");
        date = Console.ReadLine();


        Console.WriteLine("Format:hour:minute:second.");

        Console.Write("Enter time:");
        time = Console.ReadLine();

        dateAndTime = date + "г" + " " + time;

        isDate = DateTime.Parse(dateAndTime);
        isDate = isDate.AddHours(6);
        isDate = isDate.AddMinutes(30);
        Console.WriteLine(isDate);
    }
}

