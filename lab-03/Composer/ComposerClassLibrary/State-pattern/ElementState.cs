using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.State_pattern
{
    public abstract class ElementState
    {
        protected LightElementNode? _element;

        public void SetElement(LightElementNode element)
        {
            this._element = element;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Displaying {_element?.GetType().Name} in default state.");
        }

        public virtual void Collapse()
        {
            Console.WriteLine($"Collapsing {_element?.GetType().Name} in default state.");
        }
    }
}
