using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassLibrary
{
    public class FileWriter
    {
        public void Write(string message)
        {
            Console.WriteLine("Writing to file: " + message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine("Writing to file (newline): " + message);
        }
    }
}
