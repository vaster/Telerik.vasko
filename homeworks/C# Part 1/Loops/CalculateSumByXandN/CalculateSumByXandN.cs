using System;


    class CalculateSumByXandN
    {
        static void Main()
        {
            int x;
            int n;
            double result;
            double sum = 0;
            int counter;

            Console.Write("Enter N=");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter X=");
            x = int.Parse(Console.ReadLine());

            for(counter = 1; counter <= n; n--)
            {
                result = n - 1;
                
                if (n == 1)
                {
                    result = 1;
                }
                
                result = (result*n)/(x*n);
                sum = sum + result;
            }

            Console.WriteLine("Result is {0}", sum + 1);
        }
    }

