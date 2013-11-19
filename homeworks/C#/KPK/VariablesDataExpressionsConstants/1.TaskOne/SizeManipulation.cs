using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TaskOne
{
    public static class SizeManipulation
    {
        public static Size GetRotatedSize(Size measurableObject, double angleOfObject)
        {
            double widthOffsetByCosinus = Math.Abs(Math.Cos(angleOfObject) * measurableObject.Width);
            double widthOffsetBySinus = Math.Abs(Math.Sin(angleOfObject) * measurableObject.Width);

            double heightOffsetByCosinus = Math.Abs(Math.Cos(angleOfObject) * measurableObject.Height);
            double heightOffsetBySinus = Math.Abs(Math.Sin(angleOfObject) * measurableObject.Height);

            double offSetedWidth = widthOffsetByCosinus + heightOffsetBySinus;
            double offSetedHeight = widthOffsetBySinus + heightOffsetByCosinus;

            Size rotatedObject = new Size(offSetedWidth, offSetedHeight);

            return rotatedObject;
        }
    }
}
