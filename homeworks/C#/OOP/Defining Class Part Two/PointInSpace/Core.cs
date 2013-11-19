using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
/*
 Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
Write a static class with a static method to calculate the distance between two points in the 3D space.
Create a class Path to hold a sequence of points in the 3D space. 
Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
 */
namespace PointInSpace
{
    class Core
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");//culture US is used becouse we need to load points from file wich coordinate values are
                                                                           // represented by float point '.', otherwise a conflict will apear when we try to
                                                                           // convert it to 'Double'.

            List<Point3D> points = new List<Point3D>();
            Path storedPoints = new Path();//call empty consturctor and all points in 'Path' are saved to 'List<>' in it.
            points.AddRange(storedPoints.RetrunPoints()); // store all points from 'Path' class to our Main(Core)
            



            Console.WriteLine();
            Console.WriteLine("                y                                                          ");
            Console.WriteLine();
            Console.WriteLine("                ^                                                          ");
            Console.WriteLine("             P__. 1                                                        ");
            Console.WriteLine("            /|  .                      Euclidean Three Dimension Space     ");
            Console.WriteLine("           / |.7._____ Q               Each Point is represented by [X,Y,Z}");
            Console.WriteLine("          /  |  .    /|                values on the coordinate system     ");
            Console.WriteLine("         /   |  .   / |                                                    ");
            Console.WriteLine("        /    |  .  /  |                                                    ");
            Console.WriteLine("       /     |  . /   |                                                    ");
            Console.WriteLine("      /      |  ./    |                                                    ");
            Console.WriteLine("-z <. . . .  |  /. . .| . . . . . . > z                                    ");
            Console.WriteLine("    -1       | /.    .5                                                    ");
            Console.WriteLine("            ./                                                             ");
            Console.WriteLine("          .  1                                                             ");
            Console.WriteLine("        .                                                                  ");
            Console.WriteLine("      .                                                                    ");
            Console.WriteLine("    |_                                                                     ");
            Console.WriteLine();
            Console.WriteLine(" x                                                                         ");
            Console.WriteLine();


           

            Console.WriteLine("P " + points[0]);
            Console.WriteLine("Q " + points[1]);
            Console.WriteLine("Dsitance between P and Q = " + EuclideanDistance.CalcDistanceBetweenTwoPoints(points[0], points[1]) + " [Units]");
            points.AddRange(PathStorage.Load()); //call method to load points from a file
            Console.WriteLine();
            Console.WriteLine("Points from File:");
            Console.WriteLine();
            Console.WriteLine("K " + points[2]);
            Console.WriteLine("L " + points[3]);
            Console.WriteLine();
            PathStorage.Save(points); //invoke a method to save points in 'output.txt'
            Console.WriteLine("Points saved to output.txt.");
            Console.WriteLine();
            Console.WriteLine("Zero Point: {0}",Point3D.PointZero);



        }
    }
}
