using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05_DependencyInversion
{
    public class SoftwareProject //upperlevel project
    {
        //private JavaDeveloper javaDev = new JavaDeveloper(); //lower level class
        //private JavaScriptDeveloper jsDev = new JavaScriptDeveloper(); //lower level class

        //the upper level class "SoftwareProject" SHOULD NOT dependent on the lower level classes such as JavaDeveloper and JavaScriptDeveloper
        //this will eventually causes problems if something changes in the lowerlevel classes
        //the solution here is to program against an interface, which then should be implemented by the inhering classes (lowerlevel classes in this example)

        //public void Implement()
        //{
        //    javaDev.WriteJavaCode(); //low level class
        //    jsDev.WriteJavaScriptCode(); //low level class

        //}

        //this class doenst need to know what the lower level classes are, it just needs to know that they implement the IDeveloper interface
        //this is called Dependency Inversion and since top level class is not dependent on any of the lower level classes the dependencs is cut
        //this is a good thing because it makes the code more flexible (extensible) and easier to maintain

        private List<IDeveloper> developers;

        //constructor
        public SoftwareProject(List<IDeveloper> developers)
        {
            this.developers = developers;
        }

        public void Implement()
        {
            foreach (var developer in developers)
            {
                developer.Develop();
            }
        }
    }
}
