using System;

    class Sum3Numbers
    {
        static void Main()
        {
            int number1;
            int number2;
            int number3;

            Console.Write("Enter first int. number:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second int. number:");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter thirth int. number:");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Sum is:{0}",number1 + number2 + number3);
        }
    }

