using System;
using System.Numerics;

    class Fibonacci
    {
        static void Main()
        {
            int range;
            int counter;
            BigInteger sum = 0;
            BigInteger first = 0;
            BigInteger second = 1;

            Console.Write("Enter range:");
            range = int.Parse(Console.ReadLine());

            for (counter = 0; counter <= range; counter++)
            {

                if(counter >= 1)
                {
                sum = first + second;
                }
                first = second;
                second = sum;
                
                Console.WriteLine("{0}",sum);
            }

        }
    }

