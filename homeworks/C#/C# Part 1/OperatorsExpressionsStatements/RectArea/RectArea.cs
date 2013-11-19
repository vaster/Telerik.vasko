using System;

    class RectArea
    {
        static void Main()
        {
            double width;
            double height;

            Console.Write("Enter a height for your rectangle:");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter a width for your rectangle:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle's area is:{0}",height * width);
        }
    }

