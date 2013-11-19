using System;


    class ASCII
    {
        static void Main()
        {
            int numbericValue;
            char symbol;
            for (numbericValue = 0; numbericValue < 128; numbericValue++)
            {
                symbol = Convert.ToChar(numbericValue);
                Console.WriteLine("Symbol is {0}", symbol);
            }
        }
    }

