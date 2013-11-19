using System;

    class DivisionBy5Is0
    {
        static void Main()
        {
            int lowRange;
            int highRange;
            int p = 0;
            int temp;
            
            int range;
            

            do
            {
                Console.Write("Enter first positive int. number:");
                lowRange = int.Parse(Console.ReadLine());
                Console.Write("Ënter second positive int. number:");
                highRange = int.Parse(Console.ReadLine());
            }while((lowRange < 0) || (highRange < 0));

            if (lowRange > highRange)
            {
                temp = lowRange;
                lowRange = highRange;
                highRange = temp;
            }

            range = lowRange;
            for (; range <= highRange; range++)
            {
                if (range % 5 == 0)
                {
                    p++;
                }
            }

            Console.WriteLine("In range of ({0}:{1}) only {2} numbers can be devided by 5 with no left)",lowRange,highRange,p);
        }
    }

