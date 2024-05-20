using ComposerClassLibrary;
using ComposerClassLibrary.Command;

class Program
{
    static void Main(string[] args)
    {
        // Creating commands
        var div = new LightElementNode("div", true, false);
        var addDivClassCommand = new AddClassCommand(div, "container");

        var h1 = new LightElementNode("h1", true, false);
        var h1Text = new LightTextNode("Welcome to LightHTML!");
        var addH1ChildCommand = new AddChildCommand(h1, h1Text);

        var p = new LightElementNode("p", false, false);
        var pText = new LightTextNode("This is a simple example of LightHTML markup language.");
        var addPChildCommand = new AddChildCommand(p, pText);

        var br = new LightElementNode("br", false, true);

        var invoker = new CommandInvoker();
        invoker.AddCommand(addDivClassCommand);
        invoker.AddCommand(addH1ChildCommand);
        invoker.AddCommand(addPChildCommand);

        // Execute commands
        invoker.ExecuteCommands();

        // Adding child to div
        div.AddChild(h1);
        div.AddChild(p);

        // Printing HTML
        Console.WriteLine("Outer HTML:");
        Console.WriteLine(div.OuterHTML());
        Console.WriteLine();

        Console.WriteLine("Inner HTML:");
        Console.WriteLine(div.InnerHTML());
    }
}
