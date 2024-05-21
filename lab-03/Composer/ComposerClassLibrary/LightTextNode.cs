using ComposerClassLibrary.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary
{
    public class LightTextNode : LightNode
    {
        private string _text;

        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string OuterHTML()
        {
            return _text;
        }

        public override string InnerHTML()
        {
            return "";
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.VisitTextNode(this);
        }
    }
}
