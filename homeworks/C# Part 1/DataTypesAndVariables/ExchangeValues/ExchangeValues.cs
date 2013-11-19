using System;

    class ExchangeValue
    {
        static void Main()
        {
            int numberA = 5;
            int numberB = 10;
            int swap;

            swap = numberA;
            numberA = numberB;
            numberB = swap;

            Console.WriteLine(" Before \n numberA={0}, numberB={1} \n after \n numberA={2}, numberB={3}",swap,numberA,numberA,numberB);
            
        }
    }

