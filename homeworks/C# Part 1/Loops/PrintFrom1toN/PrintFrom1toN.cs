using System;

    class PrintFrom1toN
    {
        static void Main()
        {
            int endOfRange;
            int counter;

            Console.Write("Enter (1..N)N =");
            endOfRange = int.Parse(Console.ReadLine());

            for (counter = 1; counter <= endOfRange; counter++)
            {
                Console.WriteLine("{0}",counter);
            }
            
        }
    }

