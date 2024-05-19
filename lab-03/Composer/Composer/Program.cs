using ComposerClassLibrary;

class Program
{
    static void Main(string[] args)
    {

        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");

        LightElementNode h1 = new LightElementNode("h1", true, false);
        LightTextNode h1Text = new LightTextNode("Welcome to LightHTML!");
        h1.AddChild(h1Text);

        LightElementNode p = new LightElementNode("p", false, false);
        LightTextNode pText = new LightTextNode("This is a simple example of LightHTML markup language.");
        p.AddChild(pText);

        LightElementNode br = new LightElementNode("br", false, true);
        Console.WriteLine("Break tag:");
        Console.WriteLine(br.OuterHTML());
        Console.WriteLine();


        div.AddChild(h1);
        div.AddChild(p);

        Console.WriteLine("Outer HTML:");
        Console.WriteLine(div.OuterHTML());
        Console.WriteLine();

        Console.WriteLine("Inner HTML:");
        Console.WriteLine(div.InnerHTML());
    }

}