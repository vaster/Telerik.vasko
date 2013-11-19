using System;

    class Cards
    {
        static void Main()
        {
            int counter;
            int color;
            for (color = 1; color <= 4; color++)
            {
                
                for (counter = 1; counter <= 13; counter++)
                {
                    switch (counter)
                    {
                        case 1: Console.Write("Ace "); break;
                        case 2: Console.Write("2 "); break;
                        case 3: Console.Write("3 "); break;
                        case 4: Console.Write("4 "); break;
                        case 5: Console.Write("5 "); break;
                        case 6: Console.Write("6 "); break;
                        case 7: Console.Write("7 "); break;
                        case 8: Console.Write("8 "); break;
                        case 9: Console.Write("9 "); break;
                        case 10: Console.Write("10 "); break;
                        case 11: Console.Write("Jack "); break;
                        case 12: Console.Write("Queen "); break;
                        case 13: Console.Write("King "); break;
                        
                    }
                    switch (color)
                    {
                        case 1: Console.WriteLine("of Spade"); break;
                        case 2: Console.WriteLine("of Heart"); break;
                        case 3: Console.WriteLine("of Diamond"); break;
                        case 4: Console.WriteLine("of Club"); break;
                    }
                }
                
            }
        }
    }

