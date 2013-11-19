using System;

    class WichIsBigger
    {
        static void Main()
        {
            int numberA;
            int numberB;
            int numberC;

            Console.Write("numberA =");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("numberB =");
            numberB = int.Parse(Console.ReadLine());
            Console.Write("numberC =");
            numberC = int.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    Console.WriteLine("{0} is the biggest",numberA);
                }
                if (numberA < numberC)
                {
                    Console.WriteLine("{0} is the biggest",numberC);
                }
            }
            if (numberA < numberB)
            {
                if (numberB > numberC)
                {
                    Console.WriteLine("{0} is the biggest",numberB);
                }
                if (numberB < numberC)
                {
                    Console.WriteLine("{0}, is the biggest",numberC);
                }
            }
            if (numberA == numberB && numberB == numberC)
            {
                Console.WriteLine("Equals");
            }
        }
    }

