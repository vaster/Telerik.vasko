using System;


    class PrintSequence
    {
        static void Main()
        {
            int counter;
            for (counter = 2; counter < 12; counter++)
            {
                if (counter % 2 == 0)
                    Console.Write(counter+" ");
                else
                    Console.Write(-counter+" ");
            }

        }
    }

