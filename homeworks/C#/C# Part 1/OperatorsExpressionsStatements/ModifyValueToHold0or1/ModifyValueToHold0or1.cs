using System;

    class ModifyValueToHold0or1
    {
        static void Main()
        {
            int n;
            int v;
            int p;
            int result;
            int counter = 4;
            double caliber;
            int intCaliber;
            int max;
            double rest;
            int intRest;

            Console.Write("Enter int. number:");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter bit to be added(0 or 1):");
                v = int.Parse(Console.ReadLine());
            }while((v> 2 && v> -1));
            Console.Write("Enter bit position:");
            p = int.Parse(Console.ReadLine());

            if (v == 1)
            {
                result = n | (1 << p);
                Console.WriteLine("{0} modifed is {1}", n,result );
            }
            if (v == 0)
            {
                do
                {
                    caliber = Math.Pow(2, counter);
                    intCaliber = (int)caliber;
                    counter++;
                }while(intCaliber < n);
                max = intCaliber - 1;
                rest = max - Math.Pow(2, p);
                intRest = (int)rest;
                result = n & intRest;
                Console.WriteLine("{0} modifed is {1}", n, result);
            }
           
        }
    }

