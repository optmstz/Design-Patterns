using AbstractFactoryClassLibrary.Devices;
using AbstractFactoryClassLibrary.Devices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.Factory
{
    public class SamsungDeviceFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new SamsungLaptop();
        public INetbook CreateNetbook() => new SamsungNetbook();
        public IEBook CreateEBook() => new SamsungEBook();
        public ISmartphone CreateSmartphone() => new SamsungSmartphone();
    }
}
