using System;

    class PointInCircle
    {
        static void Main()
        {
            double width;
            double height;
            int radius = 5;

            Console.Write("Enter cоordinate for x:");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter cоordinate for y:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine(((width * width) + (height * height)) <= (radius * radius) ? "True" : "False");
        }
    }

