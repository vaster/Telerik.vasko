using System;

    class PrintNull
    {
        static void Main()
        {
            int? valueA = null;
            double? valueB = null;
            Console.WriteLine("Nullable type");
            Console.WriteLine("Int = {0}\nDouble = {1}",valueA,valueB);

            Console.WriteLine("\n");

            valueA = 0;
            valueB = 0;
            Console.WriteLine("Value of 0");
            Console.WriteLine("Int = {0}\nDouble = {1}", valueA, valueB);
        }
    }

