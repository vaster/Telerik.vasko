using System;

    class FindThe3thBit
    {
        static void Main()
        {
            int number;
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(((number & (8)) == 0) ? "Number is 0" : "Number is 1");
        }
    }

