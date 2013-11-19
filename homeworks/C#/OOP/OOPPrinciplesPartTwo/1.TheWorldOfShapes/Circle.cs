using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TheWorldOfShapes
{
    public class Circle : Shape
    {
        public Circle(int width)
            : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow((Width / 2), 2);
        }
    }
}
