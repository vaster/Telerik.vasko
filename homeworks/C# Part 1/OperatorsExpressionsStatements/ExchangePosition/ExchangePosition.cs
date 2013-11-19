using System;

    class ExchangePosition
    {
        static void Main()
        {
            uint number;
            uint result26;
            uint result25;
            uint result24;
            uint result3;
            uint result4;
            uint result5;

            Console.Write("Enter int. number:");
            number = uint.Parse(Console.ReadLine());

            result26 = number & (1<<26);
            if (result26 == 67108864)
            {
                result26 = 1;
            }

            result25 = number & (1<<25);
            if (result25 == 33554432)
            {
                result25 = 1;
            }

            result24 = number & (1 << 24);
            if (result24 == 16777216)
            {
                result24 = 1;
            }
            

            result3 = number & (1 << 3);
            if (result3 == 8)
            {
                result3 = 1;
            }
            

            result4 = number & (1 << 4);
            if (result4 == 16)
            {
                result4 = 1;
            }
           

            result5 = number & (1 << 5);
            if (result5 == 32)
            {
                result5 = 1;
            }


            if ((result24 == 0 && result3 == 1) || (result24 == 1 && result3 == 0))
            {
                number = number ^ 16777224;
            }


            if ((result25 == 0 && result4 == 1) || (result25 == 1 && result4 == 0))
            {
                number = number ^ 33554448;
            }


            if ((result26 == 0 && result5 == 1) || (result26 == 1 && result5 == 0))
            {
                number = number ^ 67108896;
            }
            Console.WriteLine("{0}", number);
        }
    }

