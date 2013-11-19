using System;
using System.Collections.Generic;

class ReadNumberMethod
{
    static void ReadNumber(int start, int end)
    {
        int number = 0;
        Console.Write("Enter number:");
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            throw new FormatException(string.Format("Invalid nubmer entered at line 12."));
        }
        if (number < start || number > end)
        {
           
            throw new Exception(string.Format("Number not in range."));
        }
    }

    /*_______________________________________________________*/
    static void Main(string[] args)
    {
        int start;
        int end;

        Console.Write("Enter start for the range:");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter end for the range:");
        end = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            ReadNumber(start, end);
        }

    }
}

