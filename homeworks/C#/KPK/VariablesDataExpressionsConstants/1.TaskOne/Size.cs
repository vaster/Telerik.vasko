﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TaskOne
{
    // Used properties for proper OOP.
    // GetRotatedSize is in 'SizeManipulation' Class with proper variable names.
    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
