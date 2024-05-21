using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.Command
{
    public class RemoveChildCommand : ICommand
    {
        private LightElementNode _parent;
        private LightNode _child;

        public RemoveChildCommand(LightElementNode parent, LightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            _parent.GetChildren().Remove(_child);
        }
    }
}
