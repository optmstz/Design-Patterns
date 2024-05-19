using FlyweightClassLibrary;
using System;
using System.Collections.Generic;

namespace ComposerClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";

            BookProcessor bookProcessor = new BookProcessor(bookUrl);
            string[] bookLines = bookProcessor.GetBookLines();

            BookHTMLConverter htmlConverter = new BookHTMLConverter(bookLines);
            htmlConverter.ConvertToHTML();
            List<LightNode> htmlNodes = htmlConverter.GetHTMLNodes();

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used before optimizing: {memoryUsed} bytes");

            LightWeightOptimizer.Optimize(htmlNodes);

            memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used after optimizing: {memoryUsed} bytes");

            foreach (var node in htmlNodes)
            {
                Console.WriteLine(node.OuterHTML());
            }
        }
    }
}
