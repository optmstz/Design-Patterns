using ProxyClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, "..", "..", "..", "test.txt");

        using (var checker = new SmartTextChecker(filePath))
        {
            checker.DisplayTextArray();
        }

        using (var locker = new SmartTextReaderLocker(filePath, "pattern"))
        {
            locker.DisplayTextArray();
        }
    }
}
