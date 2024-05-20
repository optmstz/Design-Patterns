using ObserverClassLibrary;
using System;

namespace ObserverClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new LightElementNode("button", isBlock: true, isSelfClosing: false);
            button.AddClass("btn");
            button.AddChild(new LightTextNode("Click me"));

            button.AddEventListener("click", () =>
            {
                Console.WriteLine("Button clicked!");
            });

            button.DispatchEvent("click");
        }
    }
}
