using System.Net;

public class BookProcessor
{
    private readonly string _bookUrl;

    public BookProcessor(string bookUrl)
    {
        _bookUrl = bookUrl;
    }

    public string GetBookText()
    {
        using (WebClient client = new WebClient())
        {
            return client.DownloadString(_bookUrl);
        }
    }

    public string[] GetBookLines()
    {
        string bookText = GetBookText();
        return bookText.Split('\n');
    }
}