using System;

    class FactorialDevidedByDifference
    {
        static void Main()
        {
            int k;
            int n;
            int counter;
            int factorialK=1;
            int factrialN=1;
            int keepN;
            int keepK;
            int result;
            do
            {
                Console.Write("Enter K for K>1, K = ");
                k = int.Parse(Console.ReadLine());
            }while(k < 1);

            do
            {
                Console.Write("Enter N for N>K, N = ");
                n = int.Parse(Console.ReadLine());
            } while (n < k);
            keepK = k;
            keepN = n;
            for (counter = 1; counter <= n; k--, n--)
            {
                if (k == 0)
                {
                    k = 1;
                }
                factorialK = factorialK * k;
                factrialN = factrialN * n;
            }
            result = (factrialN * factorialK) / (keepK - keepN);
            Console.WriteLine("Result is {0}",result);
        }
    }

