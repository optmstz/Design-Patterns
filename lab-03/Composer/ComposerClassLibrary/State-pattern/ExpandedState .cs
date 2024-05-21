using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.State_pattern
{
    public class ExpandedState : ElementState
    {
        public override void Display()
        {
            Console.WriteLine($"Displaying {_element?.GetType().Name} in expanded state.");
        }

        public override void Collapse()
        {
            Console.WriteLine($"Collapsing {_element?.GetType().Name} from expanded state.");
            _element?.TransitionTo(new CollapsedState());
        }
    }
}
