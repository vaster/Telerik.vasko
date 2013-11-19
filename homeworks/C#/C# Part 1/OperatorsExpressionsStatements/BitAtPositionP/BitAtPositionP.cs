using System;

    class BitAtPositionP
    {
        static void Main()
        {
            int p;
            int v;
            int result;

            Console.Write("Enter int. Value:");
            v = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position to look for '1':");
            p = int.Parse(Console.ReadLine());
            
            result = (v &(1 << p));
            if (result == Math.Pow(2, p))
                Console.WriteLine("It is 1.");
            else
                Console.WriteLine("Sorry, next time.");
        }
    }

