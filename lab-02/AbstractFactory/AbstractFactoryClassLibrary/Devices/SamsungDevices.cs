using AbstractFactoryClassLibrary.Devices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.Devices
{
    public class SamsungLaptop : ILaptop
    {
        public string GetDetails() => "Samsung Laptop";
        public string GetProcessor() => "Exynos 990";
    }

    public class SamsungNetbook : INetbook
    {
        public string GetDetails() => "Samsung Netbook";
        public string GetProcessor() => "Exynos 990";
    }

    public class SamsungEBook : IEBook
    {
        public string GetDetails() => "Samsung EBook";
        public int GetBatteryLife() => 8; 
    }

    public class SamsungSmartphone : ISmartphone
    {
        public string GetDetails() => "Samsung Smartphone";
        public string GetOperatingSystem() => "Android";
    }
}
