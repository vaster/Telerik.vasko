using System;

    class DivideBy5and7
    {
        static void Main()
        {
            int number = 0;
            Console.WriteLine("Enter a number:");
            number =int.Parse(Console.ReadLine());
          
            if (number % 7 == 0 && number % 5 ==0)
            {
                Console.WriteLine("Divide without reminder");
            }
        }
    }

