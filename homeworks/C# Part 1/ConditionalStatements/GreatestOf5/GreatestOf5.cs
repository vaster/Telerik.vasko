using System;

    class GreatestOf5
    {
        static void Main()
        {
            double[] number = new double[5] ;
            double max = 0;
            int counter;

            for(counter = 0; counter < number.Length; counter++)
            {
                Console.Write("Enter number:");
                number[counter] = double.Parse(Console.ReadLine());
                if(number[counter] > max)
                {
                    max = number[counter];
                }
            }
            Console.WriteLine("Greatest is {0}",max);

        }
    }

