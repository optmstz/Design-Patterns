using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public interface IEventTarget
    {
        void AddEventListener(string eventType, Action eventHandler);
    }
}
