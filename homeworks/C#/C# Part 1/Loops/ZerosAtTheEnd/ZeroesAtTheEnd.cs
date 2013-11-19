using System;

    class ZeroesAtTheEnd
    {
        static void Main()
        {
            long number;
            int counter;
            long factorial = 1;
            int zero;

            Console.Write("Enter number:");
            number = long.Parse(Console.ReadLine());

            zero = (int)(number / 5);

            for (counter = 1; counter <= number; number--)
            {
                factorial = number * factorial;
            }

            Console.WriteLine("The factorial is {0}, there are {1} zeroes at the end",factorial,zero);
            //За 50 000, ще използваме BigIntiger,който е  ограничен само от оперативната памет на машината.

        }
    }

