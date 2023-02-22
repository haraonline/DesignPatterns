﻿using System.ComponentModel.Design;
using System.Reflection.Emit;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            ///SOLID is an acronym for five design principles in software development that are intended to help make code more flexible, maintainable, and easy to understand.
            ///S - Single Responsibility Principle: A class should have only one reason to change.This means that each class should have a single, clear responsibility that it performs well.
            ///O - Open/Closed Principle: A software module should be open for extension but closed for modification.This means that existing code should be protected from changes but should be able to be extended to add new functionality.
            ///L - Liskov Substitution Principle: A subclass should be able to be used in place of its parent class without any problems.This means that derived classes should be able to be substituted for their base classes without breaking the program.
            ///I - Interface Segregation Principle: A client should not be forced to implement interfaces they do not use. This means that interfaces should be designed to be as small and specific as possible.
            ///D - Dependency Inversion Principle: High-level modules should not depend on low-level modules. Both should depend on abstractions.This means that code should be organized in such a way that high-level code is independent of low-level details, which can help make the code more modular and easier to maintain.
            ///
            /// Overall, these principles help to ensure that code is designed in a way that is flexible, maintainable, and easy to understand, which can help reduce bugs and make development more efficient.
            /// </summary>/// 


            ShoppingList lst = new ShoppingList();
            lst.AddItem("Apple");
            lst.AddItem("Banana");
            lst.AddItem("Oranges");

            Console.WriteLine(lst);           

        }
    }
}