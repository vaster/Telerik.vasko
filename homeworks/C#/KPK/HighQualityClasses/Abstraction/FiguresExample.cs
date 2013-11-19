﻿using System;

namespace Abstraction
{
    class FiguresExample
    {
        // For abstraction now we can treat Rect. and Circle as Figure.
        static void Main()
        {
            Figure circle = new Circle(5);

            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                circle.CalcPerimeter(), circle.CalcSurface());

            Figure rect = new Rectangle(2, 3); 

            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                rect.CalcPerimeter(), rect.CalcSurface());
        }
    }
}
