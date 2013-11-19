using System;

    class Euclidean
    {
        static void Main()
        {
            int numberA;
            int numberB;
            int keepA;
            int keepB;
            int flag = 0;

            Console.Write("Enter first number:");
            numberA = int.Parse(Console.ReadLine());

            Console.Write("Enter first number:");
            numberB = int.Parse(Console.ReadLine());

            keepA = numberA;
            keepB = numberB;

            do
            {
                if(numberA > numberB)
                {
                    numberA = numberA - numberB;
                }
                if (numberB > numberA)
                {
                    numberB = numberB - numberA;
                }
                if (numberA <= 1 || numberB <= 1)
                {
                    if (flag == 0)
                    {
                        keepA = keepA * keepB;
                    }
                    flag++;
                }

            }while(numberA != numberB);
            if (flag > 0)
            {
                Console.Write("GCD is {0}", keepA);
            }
            else
            {
                Console.Write("GCD is {0}", numberA);
            }
        }
    }

