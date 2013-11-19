using System;


    class BonusScore
    {
        static void Main()
        {
            int choice;

            Console.Write("Enter Digit in range of[1..9]:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Result is {0}", choice * 10); break;
                case 2: Console.Write("Result is {0}", choice * 10); break;
                case 3: Console.Write("Result is {0}", choice * 10); break;
                case 4: Console.Write("Result is {0}", choice * 100); break;
                case 5: Console.Write("Result is {0}", choice * 100); break;
                case 6: Console.Write("Result is {0}", choice * 100); break;
                case 7: Console.Write("Result is {0}", choice * 1000); break;
                case 8: Console.Write("Result is {0}", choice * 1000); break;
                case 9: Console.Write("Result is {0}", choice * 1000); break;
                default: Console.Write("ERROR"); break;
                   
            }
        }
    }

