using ObserverClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverClassLibrary
{
    public class LightElementNode : LightNode, IEventTarget
    {
        private string _tag;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<LightNode> _children;
        private List<string> _classes;
        private readonly EventTarget _eventTarget;

        public LightElementNode(string tag, bool isBlock, bool isSelfClosing)
        {
            _tag = tag;
            _isBlock = isBlock;
            _isSelfClosing = isSelfClosing;
            _children = new List<LightNode>();
            _classes = new List<string>();
            _eventTarget = new EventTarget();
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public void AddClass(string className)
        {
            _classes.Add(className);
        }

        public void AddEventListener(string eventType, Action eventHandler)
        {
            _eventTarget.AddEventListener(eventType, eventHandler);
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"<{_tag} class=\"{string.Join(" ", _classes)}\">");

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

        public List<LightNode> GetChildren()
        {
            return _children;
        }

        public void DispatchEvent(string eventType)
        {
            _eventTarget.DispatchEvent(eventType);
        }
    }
}
