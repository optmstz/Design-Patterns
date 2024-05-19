using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryClassLibrary.Devices.Interfaces;

namespace AbstractFactoryClassLibrary.Devices
{
    public class IPhoneLaptop : ILaptop
    {
        public string GetDetails() => "IPhone Laptop";
        public string GetProcessor() => "A14 Bionic";
    }

    public class IPhoneNetbook : INetbook
    {
        public string GetDetails() => "IPhone Netbook";
        public string GetProcessor() => "A14 Bionic";
    }

    public class IPhoneEBook : IEBook
    {
        public string GetDetails() => "IPhone EBook";
        public int GetBatteryLife() => 10;
    }

    public class IPhoneSmartphone : ISmartphone
    {
        public string GetDetails() => "IPhone Smartphone";
        public string GetOperatingSystem() => "iOS";
    }
}