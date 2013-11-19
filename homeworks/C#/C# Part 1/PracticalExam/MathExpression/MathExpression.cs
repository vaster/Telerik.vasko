using System;
using System.Threading;

    class MathExpression
    {
        static void Main()
        {
            System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");

            decimal n;
            decimal m;
            decimal p;
            decimal result;

            n = decimal.Parse(Console.ReadLine(), cultureUS);
            m = decimal.Parse(Console.ReadLine(), cultureUS);
            p = decimal.Parse(Console.ReadLine(), cultureUS);

            
            result = ((n * n) + (1/(m * p)) + 1337)/(n - ((decimal)128.523123123*p));
            result = result + (decimal)Math.Sin((int)Math.Truncate(m) % 180);

            
            Console.WriteLine("{0:F6}",result);
        }
    }

