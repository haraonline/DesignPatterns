using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_OpenClosed
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
}
