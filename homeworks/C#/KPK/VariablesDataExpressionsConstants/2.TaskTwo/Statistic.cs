using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TaskTwo
{
    public class Statistic
    {
        public void PrintStatistics(double[] numbers, int numbersCount)
        {
            double max = int.MinValue;// aways intialize a variable
            for (int i = 0; i < numbersCount; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            PrintMax(max);

            double min = int.MaxValue;// intialize new varible instant of using 'max' - misleading name.
            for (int i = 0; i < numbersCount; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            PrintMin(min);// changed method name - not sure for this one, this could be left as 'PrintMax(max)', logically-> it should be called a method for printing 'min'.

            double sum = 0;// 'tmp' changed to 'sum' and initialized befoure first usage.
            for (int i = 0; i < numbersCount; i++)
            {
                sum = sum + numbers[i];
            }

            PrintAvg(sum / numbersCount);
        }

        private void PrintMax(double max)
        {
            // TODO:
        }

        private void PrintMin(double min)
        {
            // TODO:
        }

        private void PrintAvg(double a)
        {
            // TODO:
        }
    }
}
