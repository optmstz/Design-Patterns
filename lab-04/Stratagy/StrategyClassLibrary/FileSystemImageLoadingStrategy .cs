using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return $"Loaded image '{href}' from file system.";
        }
    }
}
