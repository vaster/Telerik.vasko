using System;
using System.Collections.Generic;

class SqrtTryCatchFinally
{
    static void Main(string[] args)
    {
        int number = 0;
        double sqrt = 0;

        Console.Write("Enter number:");
        try
        {
            number = int.Parse(Console.ReadLine());
            sqrt = Math.Sqrt(number);
            if (double.IsNaN(sqrt))
            {
                Console.WriteLine("Invalid number");
            }
            else
            {

                Console.WriteLine("Result: sqrt of {0} is {1}", number, sqrt);
            }

        }

        catch (System.FormatException)
        {
            Console.WriteLine("Invalid number");
        }

        finally
        {
            Console.WriteLine("GoodBye");
        }


    }
}

