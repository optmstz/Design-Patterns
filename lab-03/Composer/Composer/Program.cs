using ComposerClassLibrary.Visitor;
using ComposerClassLibrary;
using System;
using System.Collections.Generic;

namespace ComposerClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = new List<LightNode>
            {
                new LightElementNode("div", isBlock: true, isSelfClosing: false),
                new LightTextNode("Hello, "),
                new LightElementNode("span", isBlock: false, isSelfClosing: false),
                new LightTextNode("world"),
                new LightElementNode("span", isBlock: false, isSelfClosing: true),
                new LightTextNode("!")
            };

            var htmlVisitor = new HTMLVisitor();
            Client.GenerateHTML(nodes, htmlVisitor);
            Console.WriteLine(htmlVisitor.GetHTML());
        }
    }
}
