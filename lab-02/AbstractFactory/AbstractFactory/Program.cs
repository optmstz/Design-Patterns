using System;
using AbstractFactoryClassLibrary.Factory;
using AbstractFactoryClassLibrary.Devices.Interfaces;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory xiaomiFactory = new XiaomiDeviceFactory();
            IDeviceFactory samsungFactory = new SamsungDeviceFactory();
            IDeviceFactory iProneFactory = new IPhoneDeviceFactory();

            Console.WriteLine("Xiaomi Devices:");
            DisplayDeviceDetails(xiaomiFactory);

            Console.WriteLine("\nSamsung Devices:");
            DisplayDeviceDetails(samsungFactory);

            Console.WriteLine("\nIPhone Devices:");
            DisplayDeviceDetails(iProneFactory);
        }

        static void DisplayDeviceDetails(IDeviceFactory factory)
        {
            var laptop = factory.CreateLaptop();
            var netbook = factory.CreateNetbook();
            var eBook = factory.CreateEBook();
            var smartphone = factory.CreateSmartphone();

            Console.WriteLine($"Laptop: {laptop.GetDetails()}, Processor: {laptop.GetProcessor()}");
            Console.WriteLine($"Netbook: {netbook.GetDetails()}, Processor: {netbook.GetProcessor()}");
            Console.WriteLine($"EBook: {eBook.GetDetails()}, Battery Life: {eBook.GetBatteryLife()} hours");
            Console.WriteLine($"Smartphone: {smartphone.GetDetails()}, OS: {smartphone.GetOperatingSystem()}");
        }
    }
}
