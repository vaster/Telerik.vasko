using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        decimal x;
        decimal y;

        x = decimal.Parse(Console.ReadLine());
        y = decimal.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("{0}",0);
        }
        if (x > 0 && y > 0)
        {
            Console.WriteLine("{0}", 1);
        }
        if (x < 0 && y > 0)
        {
            Console.WriteLine("{0}", 2);
        }
        if (x < 0 && y < 0)
        {
            Console.WriteLine("{0}", 3);
        }
        if (x > 0 && y < 0)
        {
            Console.WriteLine("{0}", 4);
        }
        if (x == 0 && y != 0)
        {
            Console.WriteLine("{0}", 5);
        }
        if (x != 0 && y == 0)
        {
            Console.WriteLine("{0}", 6);
        }
    }
}

