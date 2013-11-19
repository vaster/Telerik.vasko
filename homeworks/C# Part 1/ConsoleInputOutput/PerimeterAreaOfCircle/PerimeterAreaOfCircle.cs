using System;

    class PerimeterAreaOfCircle
    {
        static void Main()
        {
            double radius;

            Console.Write("Enter radius of circle:");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter of the circle with radius r = {0} is {1}",radius,2*Math.PI*radius);
            Console.WriteLine("Area of the circle with radius r = {0} is {1}",radius,Math.PI*radius*radius);
        }
    }

