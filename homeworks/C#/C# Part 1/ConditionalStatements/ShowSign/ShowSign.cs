using System;

class ShowSign
{
    static void Main()
    {
        double numberA;
        double numberB;
        double numberC;

        Console.Write("Enter numberA:");
        numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter numberB:");
        numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter numberC");
        numberC = double.Parse(Console.ReadLine());

        if (numberA < 0)
        {
            if (numberB >= 0 && numberC >= 0)
            {
                Console.WriteLine("Sign is '-'");
            }

            if (numberB >= 0 && numberC < 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberB < 0 && numberC >= 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberB < 0 && numberC < 0)
            {
                Console.WriteLine("Sign is '-'");
            }

        }
        if (numberB < 0)
        {
            if (numberA >= 0 && numberC >= 0)
            {
                Console.WriteLine("Sign is '-'");
            }

            if (numberA >= 0 && numberC < 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberA < 0 && numberC >= 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberA < 0 && numberC < 0)
            {
                Console.WriteLine("Sign is '-'");
            }
        }
        if (numberC < 0)
        {
            if (numberB >= 0 && numberA >= 0)
            {
                Console.WriteLine("Sign is '-'");
            }

            if (numberB >= 0 && numberA < 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberB < 0 && numberA >= 0)
            {
                Console.WriteLine("Sign is '+'");
            }
            if (numberB < 0 && numberA < 0)
            {
                Console.WriteLine("Sign is '-'");
            }
        }
    }
}

