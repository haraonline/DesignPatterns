using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class AreaCalculator
    {
        //methods
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (Shape shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
