using AbstractFactoryClassLibrary.Devices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.Devices
{
    public class XiaomiLaptop : ILaptop
    {
        public string GetDetails() => "Kiaomi Laptop";
        public string GetProcessor() => "Snapdragon 8cx";
    }

    public class XiaomiNetbook : INetbook
    {
        public string GetDetails() => "Kiaomi Netbook";
        public string GetProcessor() => "Snapdragon 8cx";
    }

    public class XiaomiEBook : IEBook
    {
        public string GetDetails() => "Kiaomi EBook";
        public int GetBatteryLife() => 12;
    }

    public class XiaomiSmartphone : ISmartphone
    {
        public string GetDetails() => "Kiaomi Smartphone";
        public string GetOperatingSystem() => "Android";
    }
}
