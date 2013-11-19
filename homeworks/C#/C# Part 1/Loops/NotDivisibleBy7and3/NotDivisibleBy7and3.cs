using System;

    class NotDivisibleBy7and3
    {
        static void Main()
        {
            int endOfRange;
            int counter;
            

            Console.Write("Enter number for end of range(1...N), N=");
            endOfRange = int.Parse(Console.ReadLine());

            for (counter = 0; counter <= endOfRange; counter++)
            {
                if(counter%(3*7)!=0)
                {
                    Console.WriteLine("{0}",counter);
                }
            }

        }
    }

