using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05_DependencyInversion
{
    public class JavaScriptDeveloper : IDeveloper
    {
        public void Develop()
        {
            WriteJavaScriptCode();
        }

        public void WriteJavaScriptCode()
        {
            Console.WriteLine("JavaScript developer writes JavaScript code ...");
        }
    }
}
