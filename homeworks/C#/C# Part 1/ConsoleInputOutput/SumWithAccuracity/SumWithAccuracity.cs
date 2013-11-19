using System;

    class SumWithAccuracity
    {
        static void Main()
        {
            float counter;
            float sum =1;
            float sum1 = 1;
            float sum2 = 1;

            for (counter = 2; sum >= 0.001;counter++ )
            {
                
                sum1 = sum1 + (1 / counter);
                sum2 = sum1 - (1 / (counter + 1));
                sum = sum1 - sum2;
            }
            Console.WriteLine("{0}",sum);
        }
    }

