using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string input;
        int number;
        int sum = 0;
       

        input = Console.ReadLine();
        do
        {
            sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
               
                char[] sumIt = input.ToCharArray();
                //Console.WriteLine(sumIt[i]);
                if (sumIt[i] != '-' && sumIt[i] != '.')
                {
                    number = sumIt[i] - 48;
                    sum = sum + number;

                }

            }
            input = sum.ToString();
            //Console.WriteLine("{0}", input);
        } while (sum > 9);

        Console.WriteLine("{0}", sum);
    }
}

