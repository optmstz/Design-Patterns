using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.State_pattern
{
    public class CollapsedState : ElementState
    {
        public override void Display()
        {
            Console.WriteLine($"Displaying {_element?.GetType().Name} in collapsed state.");
        }

        public override void Collapse()
        {
            Console.WriteLine($"Collapsing {_element?.GetType().Name} in collapsed state.");
        }
    }
}
