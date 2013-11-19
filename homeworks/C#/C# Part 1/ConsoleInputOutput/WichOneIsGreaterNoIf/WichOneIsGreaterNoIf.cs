using System;

    class WichOneIsGreaterNoIf
    {
        static void Main()
        {
            double numberA;
            double numberB;

            Console.Write("Enter first nubmer:");
            numberA = double.Parse(Console.ReadLine());

            Console.Write("Enter second number:");
            numberB = double.Parse(Console.ReadLine());

            Console.WriteLine(numberA > numberB ? "{0} is greater ":"{1} is greater",numberA,numberB);

        }
    }

