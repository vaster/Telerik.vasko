using System;
using System.Threading;




class AstrologicalDigits
{

    static void Main()
    {
        System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");


        decimal n;
        


        n = Math.Abs(decimal.Parse(Console.ReadLine(), cultureUS));
        
        do
        {
            decimal keepInt = 0;
            decimal keepDecimal = 0;
            decimal keeperInt = 0;
            decimal sumA = 0;
            decimal sumB = 0;
            decimal keeperDecimal = 0;
            decimal decimalPower = 0;
            string tricky;
            int checkInt = 0;
            int checkDecimal = 0;
            int checkAfterDec = 0;

            


            keepInt = Math.Truncate(n);

           

            do
            {
                keepInt = Math.Truncate((keepInt)) / 10;
                checkInt++;
            } while (keepInt < 0 || keepInt > 9);
            keepInt = Math.Truncate(n);
            checkAfterDec = checkInt;

            do
            {
                sumA = Math.Truncate(keepInt) / (decimal)Math.Truncate(Math.Pow(10, checkInt));
                keeperInt = keeperInt + Math.Truncate(sumA);
                keepInt = Math.Truncate(keepInt) % (decimal)Math.Truncate(Math.Pow(10, checkInt));
                checkInt--;

            } while (checkInt != -1);
            
            tricky = Convert.ToString(n);
            //Console.WriteLine("{0}", tricky);
            if (n % 1 != 0)
            {
                tricky = tricky.Substring(tricky.IndexOf(",") + 1);
                keepDecimal = decimal.Parse(tricky);

            }
            if (n % 1 == 0)
            {
                keepDecimal = 0;

            }
            
            do
            {
                keepDecimal = keepDecimal * 10;
            } while (keepDecimal % 10 != 0);

            keepDecimal = Math.Truncate(keepDecimal) / 10;

            decimalPower = keepDecimal;
            do
            {
                decimalPower = Math.Truncate(decimalPower) / 10;
                checkDecimal++;
            } while (decimalPower < 0 || decimalPower > 9);

            do
            {
                sumB = Math.Truncate(keepDecimal) / (decimal)Math.Truncate(Math.Pow(10, checkDecimal));
                keeperDecimal = keeperDecimal + Math.Truncate(sumB);
                keepDecimal = Math.Truncate(keepDecimal) % (decimal)Math.Truncate(Math.Pow(10, checkDecimal));
                checkDecimal--;
            } while (checkDecimal != -1);
            //Console.WriteLine("{0}", keeperDecimal);
            n = keeperDecimal + keeperInt;
        } while (n > 9);



        
        Console.WriteLine("{0}", n);





    }
}

