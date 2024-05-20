using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public string LoadImage(string href)
        {
            return $"Loaded image '{href}' from network.";
        }
    }

}
