using System;


class WeAllLoveBits
{
    static void Main()
    {
        int n;
        int number;
        int numberInBits;
        int countBits = 0;
        int i = 0;
        int keepNumber;
        int max;
        int inverse;
        int reverse = 0;

        n = int.Parse(Console.ReadLine());
        ////////////////////////////////////
        int[] print = new int[n];
        ////////////////////////////////////
        do
        {
            number = int.Parse(Console.ReadLine());
            numberInBits = number;
            keepNumber = number;
            countBits = 0;
            i = 0;
            reverse = 0;
            do
            {
                numberInBits = numberInBits / 2;
                countBits++;
            } while (numberInBits > 0);
            //////////////////////////////////////
            int[] bitReverse = new int[countBits];
            //////////////////////////////////////
            numberInBits = number;
            do
            {

                numberInBits = number % 2;

                if (numberInBits == 1)
                {
                    bitReverse[i] = 2;
                }
                number = number / 2;
                i++;

            } while (i < countBits);
            max = (int)Math.Pow(2, countBits) - 1;
            inverse = max - keepNumber;
            Array.Reverse(bitReverse);
            for (int j = 0; j < bitReverse.Length; j++)
            {
                reverse = (int)Math.Pow(bitReverse[j], j) + reverse;
                //Console.WriteLine("{0}", reverse);
            }
            number = (keepNumber ^ inverse) & reverse;
            print[n - 1] = number;
            n--;
        } while (n > 0);
        ////////////////////////////////////////
        //Console.WriteLine("{0}",print.Length);
        for (int j = print.Length - 1; j >= 0; j--)
        {
            Console.WriteLine("{0}", print[j]);
        }


    }
}

