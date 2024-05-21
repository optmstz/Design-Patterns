using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.Visitor
{
    public interface INodeVisitor
    {
        void VisitElementNode(LightElementNode elementNode);
        void VisitTextNode(LightTextNode textNode);
    }
}
