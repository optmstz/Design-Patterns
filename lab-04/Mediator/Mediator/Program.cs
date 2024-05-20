using MediatorClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Create Runways and Aircrafts
        var runway1 = new Runway();
        var runway2 = new Runway();
        var aircraft1 = new Aircraft("A1");
        var aircraft2 = new Aircraft("A2");

        var commandCentre = new CommandCentre([runway1, runway2], [aircraft1, aircraft2]);

        // Aircrafts requesting to land and take off
        aircraft1.Land();
        aircraft2.Land();
        aircraft1.TakeOff();
        aircraft2.TakeOff();
    }
}