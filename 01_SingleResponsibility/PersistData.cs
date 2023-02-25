using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignPatterns.SingleResponsibility
{
    //PersistData class
    internal class PersistData
    {
        public static void WriteToFile(string fileName, List<string> list)
        {
            StreamWriter writer = new StreamWriter(fileName, true);
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}
