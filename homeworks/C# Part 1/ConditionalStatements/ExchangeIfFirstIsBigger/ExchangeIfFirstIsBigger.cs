using System;

    class ExchangeIfFirstIsBigger
    {
        static void Main()
        {
            int numberA;
            int numberB;
            int temp;

            Console.Write("Enter first number:");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            numberB = int.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                temp = numberA;
                numberA = numberB;
                numberB = temp;

                Console.WriteLine("After exchange: first number ={0}, second number = {1}", numberA, numberB);
            }
            else
            {
                Console.WriteLine("Do nothing.");
            }
        }
    }

