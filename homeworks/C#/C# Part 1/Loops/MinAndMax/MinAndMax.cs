using System;


    class MinAndMax
    {
        static void Main()
        {
            int count;
            int counter;
            int min = 0;
            int max = 0;
            int number;
            bool flag = false;


            Console.Write("Enter count of number:");
            count = int.Parse(Console.ReadLine());

            for (counter = 1; counter <= count; counter++)
            {
                Console.Write("{0}.number=",counter);
                number = int.Parse(Console.ReadLine());
                if (max < number)
                {
                    max = number;
                  
                }
                if(!flag)
                {
                    min = number;
                }
                
                if (min >= number)
                {
                    min = number;
                }
                flag = true;
            }
            Console.WriteLine("min is {0}, max is {1}",min, max);
        }
    }

