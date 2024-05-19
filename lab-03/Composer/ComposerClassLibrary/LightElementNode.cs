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

        public LightElementNode(string tag, bool isBlock, bool isSelfClosing)
        {
            _tag = tag;
            _isBlock = isBlock;
            _isSelfClosing = isSelfClosing;
            _children = new List<LightNode>();
            _classes = new List<string>();
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public void AddClass(string className)
        {
            _classes.Add(className);
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
    }
}
