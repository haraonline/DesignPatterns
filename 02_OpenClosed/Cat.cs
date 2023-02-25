using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_OpenClosed
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Mewow!");
        }
    }
}
