﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Rectangle : Shape
    {
        //properties
        public double Width { get; set; }
        public double Height { get; set; }

        //consturctor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //methods
        public override double Area()
        {
            return Width * Height;
        }
    }
}
