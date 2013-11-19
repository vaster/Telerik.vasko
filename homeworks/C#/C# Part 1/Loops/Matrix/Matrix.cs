using System;

    class Matrix
    {
        static void Main()
        {
            int range;
            int counter = 1;
            int newRoll;
            int innerRange = 0;
            int newCounter = 1;
            

            Console.Write("Enter N, for N < 20, N =");
            range = int.Parse(Console.ReadLine());
            innerRange = range;
            for (newRoll = 1; newRoll <= range; newRoll++)
            {
                
               if (newRoll > 1)
                {
                    counter = newRoll;
                    newCounter = counter;
                    innerRange = innerRange + 1;
                   
                }
                for (counter = newCounter;counter <= innerRange; counter++)
                {
                        Console.Write("{0} ", counter);
                    if (counter == innerRange)
                        {
                            Console.WriteLine("");
                            
                        }
                }
                
            }

        }
    }

