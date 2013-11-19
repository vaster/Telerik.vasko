using System;

    class Triangle
    {
        static void Main()
        {
            char symbol = '\u00A9';
            Console.WriteLine("\t\t\t\t{0}",symbol);
            Console.WriteLine("\t\t\t{0}\t\t{1}", symbol,symbol);
            Console.WriteLine("\t\t{0}\t\t\t\t{1}", symbol, symbol);
            Console.WriteLine("\t{0}\t\t\t\t\t\t{1}", symbol, symbol);
            Console.WriteLine("{0}\t\t\t\t\t\t\t\t{1}", symbol, symbol);
                                       
        }
    }

