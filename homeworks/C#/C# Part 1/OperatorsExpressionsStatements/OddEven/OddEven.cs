using System;

    class OddEven
    {
        static void Main()
        {
            int number = 0;
           
            
            Console.WriteLine("Enter a number:");
            number =int.Parse(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
                
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

