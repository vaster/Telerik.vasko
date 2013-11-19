using System;

    class DescendingOrder
    {
        static void Main()
        {
            double numberA;
            double numberB;
            double numberC;
            int flagA = 0;
            int flagB = 0;

            Console.Write("numberA =");
            numberA = double.Parse(Console.ReadLine());
            Console.Write("numberB =");
            numberB = double.Parse(Console.ReadLine());
            Console.Write("numberC =");
            numberC = double.Parse(Console.ReadLine());


            if(numberA > numberB)
            {
                if(numberA > numberC)
                {
                    Console.WriteLine("{0}",numberA);
                }
                if (numberA <= numberC)
                {
                    Console.WriteLine("{0}",numberC);
                    Console.WriteLine("{0}", numberA);
                    flagA++;
                }
                if (numberC > numberB)
                {
                    if (flagA <= 0)
                    {
                        Console.WriteLine("{0}", numberC);
                    }
                    Console.WriteLine("{0}", numberB);
                    
                }
                if(numberC < numberB)
                {
                    Console.WriteLine("{0}",numberB);
                    Console.WriteLine("{0}", numberC);
                    
                }
                if (numberC == numberB)
                {
                    Console.WriteLine("{0}\n{1}",numberC,numberB);
                }

            }
            if(numberB > numberA)
            {
                if(numberB > numberC)
                {
                    Console.WriteLine("{0}",numberB);

                }
                if (numberB <= numberC)
                {
                    Console.WriteLine("{0}",numberC);
                    Console.WriteLine("{0}", numberB);
                    flagB++;

                }
               

                if (numberC > numberA)
                {
                    if (flagB <= 0)
                    {
                        Console.WriteLine("{0}", numberC);
                    }
                    Console.WriteLine("{0}", numberA);
                }
                if (numberC < numberA)
                {
                    Console.WriteLine("{0}",numberA);
                    Console.WriteLine("{0}", numberC);
                }
                if (numberC == numberA)
                {
                    Console.WriteLine("{0}\n{1}",numberC,numberA);
                }
            }
            if(numberA == numberB && numberB == numberC)
            {
                Console.WriteLine("{0}\n{1}\n{2}", numberA, numberB, numberC);

            }
        }
    }

