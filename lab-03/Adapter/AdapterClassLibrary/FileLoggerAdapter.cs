using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClassLibrary
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter fileWriter;

        public FileLoggerAdapter()
        {
            this.fileWriter = new FileWriter();
        }

        public void LogToFile(string message)
        {
            fileWriter.Write(message);
        }

        public void ErrorToFile(string message)
        {
            fileWriter.Write("ERROR: " + message);
        }

        public void WarnToFile(string message)
        {
            fileWriter.Write("WARNING: " + message);
        }
    }
}
