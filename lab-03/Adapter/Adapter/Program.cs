using AdapterClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        FileLoggerAdapter fileLogger = new FileLoggerAdapter();

        fileLogger.Log("Information message");
        fileLogger.Error("Error message");
        fileLogger.Warn("Warning message");

        fileLogger.LogToFile("Logging to file");
        fileLogger.ErrorToFile("Error message");
        fileLogger.WarnToFile("Warning message");
    }
}
