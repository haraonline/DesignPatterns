using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._03_LiskovSubstitution
{
    public class Square : Rectangle
    {
        //constructor inhering from base class constructor Rectangle
        public Square(double size) : base(size, size)
        {
        }
    }
}
