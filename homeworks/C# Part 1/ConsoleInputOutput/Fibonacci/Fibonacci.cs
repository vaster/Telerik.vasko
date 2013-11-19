using System;
using System.Numerics;


    class Fibonacci
    {
        static void Main()
        {
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger other;
            int counter;
            int flag = 0;

            for (counter = 0; counter < 100; counter++)
            {
                other = first + second;
                if (flag!=1)
                {
                    Console.WriteLine("{0}", first);
                    Console.WriteLine("{0}", second);
                    flag++;
                }
                Console.WriteLine("{0}", other);
                first = second;
                second = other;
            }


        }
    }

