using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05_DependencyInversion
{
    public class JavaDeveloper : IDeveloper
    {
        public void Develop()
        {
            WriteJavaCode();
        }                
   
        
        public void WriteJavaCode()
        {
            Console.WriteLine("Java developer writes Java code ...");
        }
    }
}
