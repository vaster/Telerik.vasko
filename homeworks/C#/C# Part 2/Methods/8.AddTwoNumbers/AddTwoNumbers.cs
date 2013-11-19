using System;
using System.Numerics;


class AddTwoNumbers
{

    static BigInteger SumTwoIntegers(BigInteger numberA, BigInteger numberB)
    {
        BigInteger indexA = 0;
        BigInteger testNumberA = numberA;
        BigInteger checkA = numberA;
        BigInteger indexB = 0;
        BigInteger testNumberB = numberB;
        BigInteger checkB = numberB;
        BigInteger ultimateIndex = 0;
        BigInteger sum = 0;
        bool bigIsA = false;
        bool bigIsB = false;

        do
        {
            indexA++;
            checkA = checkA / 10;
        } while (checkA != 0);

        BigInteger[] numberAToDigits = new BigInteger[(int)indexA];

        for (BigInteger i = indexA - 1; i >= 0; i--)
        {
            numberA = testNumberA / (int)Math.Pow(10, (int)i);
            //Console.Write(numberA);
            numberAToDigits[(int)i] = numberA;
            testNumberA = testNumberA % (int)Math.Pow(10, (int)i);

        }

        for (int i = 0; i < numberAToDigits.Length; i++)
        {
            // Console.Write(numberAToDigits[i]);
        }
        /////////////////////////////////////////////

        do
        {
            indexB++;
            checkB = checkB / 10;

        } while (checkB != 0);

        BigInteger[] numberBToDigits = new BigInteger[(int)indexB];

        for (BigInteger i = indexB - 1; i >= 0; i--)
        {
            numberB = testNumberB / (int)(Math.Pow(10, (int)i));
            numberBToDigits[(int)i] = numberB;
            testNumberB = testNumberB % (int)Math.Pow(10, (int)i);
        }
        /////////////////////////////////////
        if (indexA > indexB)
        {
            ultimateIndex = indexA;
            bigIsA = true;

        }

        if (indexA <= indexB)
        {
            ultimateIndex = indexB;
            bigIsB = true;
        }

        for (int i = 0, a = 0, b = 0; i <= ultimateIndex - 1; i++, a++, b++)
        {
           

            if (bigIsA && i >= indexB)
            {
                b--;
                numberBToDigits[b] = 0;
               
            }
            //////////////////
             
            if (bigIsB && i >= indexA)
            {
                a--;
                numberAToDigits[a] = 0;
                
            }
           
           
            sum = sum + numberAToDigits[a] * (int)Math.Pow(10, i) + numberBToDigits[b] * (int)Math.Pow(10, i);
        }
        return sum;



    }


    static void Main(string[] args)
    {
        BigInteger firstNumber;
        BigInteger secondNumber;
        BigInteger sum;


        Console.Write("Enter first number:");
        firstNumber = BigInteger.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        secondNumber = BigInteger.Parse(Console.ReadLine());

        sum = SumTwoIntegers(firstNumber, secondNumber);

        Console.WriteLine(sum);

    }
}

