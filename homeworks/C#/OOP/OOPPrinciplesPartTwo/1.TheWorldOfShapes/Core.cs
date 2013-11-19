using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
 Define two new classes Triangle and Rectangle that implement the virtual method and
 return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
 Define class Circle and suitable constructor so that at initialization height must be kept equal to width and
 implement the CalculateSurface() method. Write a program that tests the behavior of
 the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
 
 */
namespace _1.TheWorldOfShapes
{
    class Core
    {
        static void Main(string[] args)
        {
            List<Shape> shapeContainer = new List<Shape>()
            {
                new Circle(12),
                new Rectangle(5,4),
                new Triangle(2,3),
            };

            foreach (var shapes in shapeContainer)
            {
                Console.WriteLine("Area of {0} is {1:#.##}",shapes.GetType().Name,shapes.CalculateSurface());
            }

        }
    }
}
