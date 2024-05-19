using BridgeClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(new VectorRenderer());
        Shape square = new Square(new RasterRenderer());
        Shape triangle = new Triangle(new VectorRenderer());

        circle.Draw();
        square.Draw();
        triangle.Draw();
    }
}