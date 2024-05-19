public class SmartTextChecker : IDisposable
{
    private SmartTextReader _textReader;

    public SmartTextChecker(string filePath)
    {
        Console.WriteLine($"Opening file: {filePath}");
        _textReader = new SmartTextReader(filePath);
    }

    public void DisplayTextArray()
    {
        _textReader.DisplayTextArray();
    }

    public void Dispose()
    {
        Console.WriteLine($"Closing file");
        _textReader.Dispose();
    }
}
