using System;

    class IntDoubleOrString
    {
        static void Main()
        {
            int choice;
            int intValue;
            double doubleValue;
            string stringValue;

            Console.WriteLine("Make a choice.\n1.Int number.\n2.Double number\n3.String");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        Console.Write("Enter int. number:");
                        intValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result is {0}", intValue + 1);
                    }break;
                case 2:
                    {
                        Console.Write("Enter double number:");
                        doubleValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result is {0}", doubleValue + 1.0);
                    }break;
                case 3:
                    {
                        Console.WriteLine("Enter string:");
                        stringValue = Console.ReadLine();
                        Console.WriteLine("Result is {0}",stringValue + '*');
                    }break;
                default: Console.WriteLine("Wrong choice:"); break;

            }
        }
    }
