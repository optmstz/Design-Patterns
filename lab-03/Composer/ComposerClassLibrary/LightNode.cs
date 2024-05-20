using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary
{
    public abstract class LightNode
    {
        public LightNode()
        {
            OnCreated();
        }

        public abstract string OuterHTML();
        public abstract string InnerHTML();

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }
    }
}
