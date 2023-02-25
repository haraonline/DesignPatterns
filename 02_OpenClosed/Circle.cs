using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Circle : Shape
    {
        //properties
        public double Radius { get; set; }

        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        //methods
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }    
}
