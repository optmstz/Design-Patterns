using ComposerClassLibrary.Visitor;
using ComposerClassLibrary.State_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary
{
    public class LightElementNode : LightNode
    {
        private string _tag;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<LightNode> _children;
        private List<string> _classes;
        private ElementState? _state;

        public string Tag => _tag;
        public List<string> Classes => _classes;

        public LightElementNode(string tag, bool isBlock, bool isSelfClosing)
        {
            _tag = tag;
            _isBlock = isBlock;
            _isSelfClosing = isSelfClosing;
            _children = new List<LightNode>();
            _classes = new List<string>();
            TransitionTo(new ExpandedState());
        }

        public void TransitionTo(ElementState state)
        {
            Console.WriteLine($"Transitioning to {state.GetType().Name} state.");
            _state = state;
            _state.SetElement(this);
        }

        public void Display()
        {
            _state?.Display();
        }

        public void Collapse()
        {
            _state?.Collapse();
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.VisitElementNode(this);
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
            OnInserted();
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
            OnRemoved();
        }

        public void AddClass(string className)
        {
            _classes.Add(className);
            OnClassListApplied();
        }

        public override string OuterHTML()
        {
            Display();

            StringBuilder sb = new StringBuilder();
            sb.Append($"<{_tag} class=\"{string.Join(" ", _classes)}\">");
            OnStylesApplied();

            foreach (var child in _children)
            {
                sb.Append(child.OuterHTML());
            }

            if (!_isSelfClosing)
            {
                sb.Append($"</{_tag}>");
            }

            return sb.ToString();
        }


        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var child in _children)
            {
                sb.Append(child.OuterHTML());
            }

            return sb.ToString();
        }

        protected override void OnInserted()
        {
            Console.WriteLine($"LightElementNode: Child inserted into {_tag}.");
        }

        protected override void OnRemoved()
        {
            Console.WriteLine($"LightElementNode: Child removed from {_tag}.");
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine($"LightElementNode: Styles applied to {_tag}.");
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine($"LightElementNode: Class list applied to {_tag}.");
        }
    }
}
