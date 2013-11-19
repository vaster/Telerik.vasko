using System;

namespace Abstraction
{
    // Abstraction------------------
    // A circle shouldn't know what is height or width, it has radius and thats all. ->removed Width and Height.
    // Encapsulation----------------
    // Added field radius so we can customize the propertie in the right way. -> Exception thrown for wrong radius.
    // Private set is a good idea -> this automaticlly makes an empty constructor unnecessary -> removed empty constructor.
    class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("A radius if circle can't be equal to zero or less. Radius: "+this.radius);
                }
                this.radius = value;
            }
        }
    }
}
