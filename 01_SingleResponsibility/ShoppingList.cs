using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class ShoppingList
    {
        //variables
        int count = 0;

        //properties
        public List<string> LebensmittelListe { get; set; } = new List<string>();

        //methods
        //add item to the shopping list
        public void AddItem(string item)
        {
            LebensmittelListe.Add((count++) + " : " + item);
            
        }
        //remove item from the shopping list
        public void RemoveItem(string item)
        {
            LebensmittelListe.Remove((count--) + " : " + item);            
        }       

        public override string ToString()
        {
            string output = "";
            foreach (var item in LebensmittelListe)
            {
                output += item + Environment.NewLine;
            }
            return output;
        }
    }
}
