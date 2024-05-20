using ComposerClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");

        LightTextNode text = new LightTextNode("Some text");
        div.AddChild(text);

        Console.WriteLine(div.OuterHTML());
    }
}