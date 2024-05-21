using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.Visitor
{
    public class HTMLVisitor : INodeVisitor
    {
        private StringBuilder _output = new StringBuilder();

        public string GetHTML()
        {
            return _output.ToString();
        }

        public void VisitElementNode(LightElementNode elementNode)
        {
            _output.Append($"<{elementNode.Tag} class=\"{string.Join(" ", elementNode.Classes)}\">");
            foreach (var child in elementNode.GetChildren())
            {
                child.Accept(this);
            }
            _output.Append($"</{elementNode.Tag}>");
        }

        public void VisitTextNode(LightTextNode textNode)
        {
            _output.Append(textNode.OuterHTML());
        }
    }
}
