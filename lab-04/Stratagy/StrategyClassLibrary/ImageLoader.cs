using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class ImageLoader
    {
        private IImageLoadingStrategy _strategy;

        public ImageLoader(IImageLoadingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IImageLoadingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void LoadImage(string href)
        {
            Console.WriteLine("ImageLoader: Loading image using the strategy.");
            string result = _strategy.LoadImage(href);
            Console.WriteLine(result);
        }
    }
}
