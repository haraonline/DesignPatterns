using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///The open-closed principle is a design principle in 
            ///software engineering that states that software entities (classes, modules, functions, etc.) 
            ///should be open for extension but closed for modification.
            ///In other words, the principle suggests that you should be
            ///able to add new functionality to a software system without having to 
            ///change the existing code.This makes the system more flexible, modular, and easier to maintain.
            ///To apply the open-closed principle, you should design your software components to be easily 
            ///extensible, usually through the use of inheritance, composition, or interfaces. 
            ///You should also avoid making changes to existing code whenever possible, and instead 
            ///create new classes or modules to add new functionality.
            ///Overall, the open-closed principle encourages you to write code 
            ///that is easy to modify and maintain, which can lead to more robust and scalable software systems.
            ///
            /// 
            /// This can be done using Abstract classes or Interfaces
            /// IMP: Nicht übertreiben mit Interfaces, da es sonst zu unübersichtlich wird
            /// Abstract classes are more flexible than interfaces ??? - copilot suggestion
            /// Abstraction might increase the complexity
            /// You dont need to confirm to this principle all the time
            /// This also applies to all other design principles 
            ///</summary>

            Rectangle r1 = new Rectangle(5, 5);
            Rectangle r2 = new Rectangle(4, 4);
            Rectangle r3 = new Rectangle(2, 3);


            Circle c1 = new Circle(3);            

            Shape[] shapes = new Shape[] { r1, r2, r3, c1 };

            AreaCalculator areaCalculator = new AreaCalculator();
            double area = areaCalculator.Area(shapes);

            Console.WriteLine(area);
            Console.ReadKey();

        }
    }
}