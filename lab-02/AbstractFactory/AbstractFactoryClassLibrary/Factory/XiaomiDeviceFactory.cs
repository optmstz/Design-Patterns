using AbstractFactoryClassLibrary.Devices;
using AbstractFactoryClassLibrary.Devices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.Factory
{
    public class XiaomiDeviceFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new XiaomiLaptop();
        public INetbook CreateNetbook() => new XiaomiNetbook();
        public IEBook CreateEBook() => new XiaomiEBook();
        public ISmartphone CreateSmartphone() => new XiaomiSmartphone();
    }
}
