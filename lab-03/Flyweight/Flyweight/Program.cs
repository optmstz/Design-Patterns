using System;
using System.Net.Http;
using System.Threading.Tasks;
using ComposerClassLibrary;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string text = await DownloadBookTextAsync(url);

        string[] lines = text.Split('\n');

        HTMLFlyweightFactory factory = new HTMLFlyweightFactory();

        FlyweightLightElementNode html = new FlyweightLightElementNode("html");
        FlyweightLightElementNode body = new FlyweightLightElementNode("body");

        bool isFirstLine = true;
        foreach (var line in lines)
        {
            FlyweightLightElementNode node;
            string tag;
            if (isFirstLine)
            {
                tag = "h1";
                isFirstLine = false;
            }
            else if (line.Length < 20)
            {
                tag = "h2";
            }
            else if (line.StartsWith(" "))
            {
                tag = "blockquote";
            }
            else
            {
                tag = "p";
            }

            HTMLFlyweight flyweight = factory.GetFlyweight(tag);
            flyweight.Operation(line.Trim());

            node = new FlyweightLightElementNode(tag);
            node.AddChild(new LightTextNode(line.Trim()));
            body.AddChild(node);
        }

        html.AddChild(body);

        long memoryUsed = Process.GetCurrentProcess().WorkingSet64;
        Console.WriteLine($"Memory : {memoryUsed} bytes");

        Console.WriteLine(html.OuterHTML());
    }

    static async Task<string> DownloadBookTextAsync(string url)
    {
        using HttpClient client = new HttpClient();
        return await client.GetStringAsync(url);
    }
}
