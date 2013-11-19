using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int b;
        uint n;
        uint number;
        uint checkNumber;
        int bit = 0;
        int bitCount = 0;
        int i = 0;
        int j = 0;

        b = int.Parse(Console.ReadLine());
        n = uint.Parse(Console.ReadLine());
        int[] keepCount = new int[n];
        do
        {
            number = uint.Parse(Console.ReadLine());
            checkNumber = number;
            ///////////////////////////////////////
            do
            {
                checkNumber = checkNumber / 2;
                bit++;
            } while (checkNumber > 0);
            /////////////////////////////////////
            checkNumber = number;
            ////////////////////////////////////
            do
            {
                checkNumber = number % 2;
                if (checkNumber == b)
                {
                    bitCount++;
                }
                number = number / 2;
                i++;
            } while (i < bit);
            n--;
            keepCount[j] = bitCount;
            bitCount = 0;
            j++;
        } while (n > 0) ;
        for (int q = 0; q < keepCount.Length; q++)
        {
            Console.WriteLine("{0}", keepCount[q]);
        }


    }
}

