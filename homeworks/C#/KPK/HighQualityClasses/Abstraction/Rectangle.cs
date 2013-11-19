using System;

namespace Abstraction
{
    // Abstraction-------------------
    // A rect. shouldn't know what is radius.-> overriden radius removed.
    // Encapsulation-----------------
    // Added fields so we can costumize their props. Private set for better encapsulation. This make the empty comstructor unwanted.
    //          You don't need to able to create rect. with no measurments.
    // Exceptions are thrown for wrong measurments.
    class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wrong value for rectanlge height. Height: " + this.height);
                }
                this.height = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wrong value for rectangle width. Width: " + this.width);
                }
                this.width = value;
            }
        }
    }
}
