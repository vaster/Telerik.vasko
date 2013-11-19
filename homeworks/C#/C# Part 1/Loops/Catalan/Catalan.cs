using System;


    class Catalan
    {
        static void Main()
        {
            int n;
            int counter;
            int numerator = 1;
            int denominator = 1;
            int factorialA;
            int factorialB;
            int factorialC = 1;

            do
            {
                Console.Write("Enter N, for N>=0, N =");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            factorialA = n * 2;
            factorialB = n + 1;
            for(counter = 1; counter <= factorialA; factorialA--, factorialB--,n--)
            {
               
                numerator = numerator * factorialA;
                if (factorialB >= 1)
                {
                    denominator = denominator * factorialB;
                }
                if (n >= 1)
                {
                    factorialC = factorialC * n;
                }
            }

            denominator = denominator * factorialC;

            Console.WriteLine("Result is {0}",numerator/denominator);
            
        }
    }

