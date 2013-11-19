using System;


    class SumN
    {
        static void Main()
        {
            int n;
            int counter;
            int sum = 0;

            Console.Write("Enter first number and:");
            n = int.Parse(Console.ReadLine());
            counter = n;
            sum = n;
            for(;counter > 0; counter--)
            {
                
                Console.Write("Enter number:");
                n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }
            Console.WriteLine("Sum = {0}",sum);
        }
    }

