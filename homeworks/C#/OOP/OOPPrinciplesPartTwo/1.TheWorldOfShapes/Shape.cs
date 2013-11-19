using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TheWorldOfShapes
{
    public abstract class Shape
    {

        private int width;
        private int height;


        //constructor
        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        //methods
        abstract public double CalculateSurface();

        //properties

        protected int Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width of the shape can not be negative by the laws of physics.");
                }
                this.width = value;
            }
        }

        protected int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height of the shape can not be negative by the laws of physics.");
                }
                this.height = value;
            }
        }

    }
}
