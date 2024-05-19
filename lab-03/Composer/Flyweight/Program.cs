using System;
using System.Net.Http;
using System.Threading.Tasks;
using ComposerClassLibrary;

class Program
{
    static async Task Main(string[] args)
    {
        // Завантажуємо текст книги з вказаного URL
        string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string text = await DownloadBookTextAsync(url);

        // Розділимо текст на рядки
        string[] lines = text.Split('\n');

        // Створимо фабрику легковаговиків для HTML елементів
        HTMLFlyweightFactory factory = new HTMLFlyweightFactory();

        // Створимо результуючий HTML документ
        LightElementNode html = new LightElementNode("html");
        LightElementNode body = new LightElementNode("body");

        // Обробка кожного рядка тексту
        bool isFirstLine = true;
        foreach (var line in lines)
        {
            LightElementNode node;
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

            // Використовуємо легковаговик для оптимізації споживання пам'яті
            HTMLFlyweight flyweight = factory.GetFlyweight(tag);
            flyweight.Operation(line.Trim());

            node = new LightElementNode(tag, line.Trim());
            body.AddChild(node);
        }

        // Додаємо тіло до HTML документу
        html.AddChild(body);

        // Виведемо результат
        Console.WriteLine(html.OuterHTML());
    }

    // Метод для завантаження тексту книги з вказаного URL
    static async Task<string> DownloadBookTextAsync(string url)
    {
        using HttpClient client = new HttpClient();
        return await client.GetStringAsync(url);
    }
}
