using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_LiskovSubstitution
{
    internal class Rectangle
    {
        //Liskov Substitution Principle (LSP) states that objects of a superclass shall be replaceable with objects
        //of its subclasses without breaking the application
        
        //properties
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        //methods
        public double Area()
        {
            return Width * Height;
        }
    }
}
