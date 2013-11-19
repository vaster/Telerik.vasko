using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInSpace
{
    public static class EuclideanDistance
    {
        static public double CalcDistanceBetweenTwoPoints(Point3D pointA, Point3D pointB)
        {
            double EuclideanVectorOfX = pointA.X - pointB.X;   //This is how a point by its cordinate is represented in - 
            double EuclideanVectorOfY = pointA.Y - pointB.Y;   // - Euclidean Three Dimension space by a vector.
            double EuclideanVectorOfZ = pointA.Z - pointB.Z;   
            return Math.Sqrt((EuclideanVectorOfX*EuclideanVectorOfX) + (EuclideanVectorOfY*EuclideanVectorOfY) + (EuclideanVectorOfZ*EuclideanVectorOfZ));
        }
    }
}
