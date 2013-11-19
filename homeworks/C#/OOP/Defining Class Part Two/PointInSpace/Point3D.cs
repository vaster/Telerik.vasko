using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PointInSpace
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D zeroPoint = new Point3D(0,0,0);

        //constructors

      

        public Point3D(double x , double y, double z) 
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        //proprites

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public static Point3D PointZero
        {
            get { return zeroPoint; }
        }



        public override string ToString()
        {
            return string.Format("Point[{0},{1},{2}]",this.x,this.y,this.z);
        }


    }
}
