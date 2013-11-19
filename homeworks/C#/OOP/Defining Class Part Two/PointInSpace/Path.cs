using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInSpace
{
    public class Path
    {
        private List<Point3D> storePoints = new List<Point3D>();

        private Point3D aPoint = new Point3D(1, 1, -1); // instance of a 'Point3D'
        private Point3D bPoint = new Point3D(1, 0.7, 0.5); // instance of a 'Point3D'


        public Path() // empty constructor
        {
            StorePoints.Add(aPoint); //when we call empty constructur we add the instances of Points in our List
            StorePoints.Add(bPoint); //
        }

        public List<Point3D> RetrunPoints()//method
        {
            return StorePoints;
        }

        public List<Point3D> StorePoints //property
        {
            get { return this.storePoints; }
            set { storePoints = value; }
        }

    }
}
