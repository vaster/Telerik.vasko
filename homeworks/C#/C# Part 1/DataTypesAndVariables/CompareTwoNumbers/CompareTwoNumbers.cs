using System;


    class CompareTwoNumbers
    {
        static void Main()
        {
            string compareNumberA;
            string compareNumberB;
            double decimalA;
            double decimalB;

            Console.WriteLine("Compare two numbers with precision of 0.000001");

            Console.Write("Enter first number: ");
            compareNumberA = Console.ReadLine();

            Console.Write("Enter second number: ");
            compareNumberB = Console.ReadLine();

            decimalA=double.Parse(compareNumberA);
            decimalB=double.Parse(compareNumberB);
            decimalA = Math.Round(decimalA, 6);
            decimalB = Math.Round(decimalB, 6);
               if(decimalA == decimalB)
                   Console.WriteLine("True");
               else
                   Console.WriteLine("False");
        }   
    }

