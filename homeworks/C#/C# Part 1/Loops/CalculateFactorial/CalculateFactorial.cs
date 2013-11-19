using System;

    class CalculateFactorial
    {
        static void Main()
        {
            int n;
            int k;
            int counter;
            int factorialN= 1;
            int factorialK = 1;
            
            
            
            do
            {
                Console.Write("Enter K for K>1, K = ");
                k = int.Parse(Console.ReadLine());
            } while (k < 1);
            do
            {
                Console.Write("Enter N for N>K, N = ");
                n = int.Parse(Console.ReadLine());
            }while(n<k);

            for (counter = 1; counter <=n; n--, k--)
            {
                if (k == 0)
                {
                    k = 1;
                }
                factorialN = factorialN * n;
                factorialK = factorialK * k;
            }

            Console.Write("Factorial  is {0}",factorialN/factorialK);
            
        }
    }

