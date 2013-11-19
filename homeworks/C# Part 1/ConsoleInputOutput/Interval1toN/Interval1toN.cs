using System;


    class Interval1toN
    {
        static void Main()
        {
            int n;
            int counter;

            Console.Write("Enter int. number for end of the interval [1..n]:");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (counter = 1; counter <= n; counter++)
                {
                    Console.WriteLine("{0}", counter);
                }
            }
            else
            {
                for (counter = 1; counter >= n; counter--)
                {
                    Console.WriteLine("{0}",counter);
                }
            }
        }
    }

