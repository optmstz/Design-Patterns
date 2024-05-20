using StrategyClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        var imageLoader = new ImageLoader(new FileSystemImageLoadingStrategy());

        // Loading image using default strategy
        Console.WriteLine("Loading image using default strategy:");
        imageLoader.LoadImage("path/to/image.jpg");
        Console.WriteLine();

        // Switching strategy to network image loading
        imageLoader.SetStrategy(new NetworkImageLoadingStrategy());

        // Loading image using network strategy
        Console.WriteLine("Loading image using network strategy:");
        imageLoader.LoadImage("http://example.com/image.jpg");
    }
}