using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverClassLibrary
{
    public class EventTarget : IEventTarget
    {
        private readonly Dictionary<string, List<Action>> _eventHandlers = new Dictionary<string, List<Action>>();

        public void AddEventListener(string eventType, Action eventHandler)
        {
            if (!_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType] = new List<Action>();
            }
            _eventHandlers[eventType].Add(eventHandler);
        }

        public void DispatchEvent(string eventType)
        {
            if (_eventHandlers.ContainsKey(eventType))
            {
                foreach (var handler in _eventHandlers[eventType])
                {
                    handler();
                }
            }
        }
    }
}
