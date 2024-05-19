using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryClassLibrary.Devices.Interfaces
{
    public interface ILaptop
    {
        string GetDetails();
        string GetProcessor();
    }
}
