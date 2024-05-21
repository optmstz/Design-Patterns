using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerClassLibrary.Visitor
{
    public class Client
    {
        public static void GenerateHTML(List<LightNode> nodes, INodeVisitor visitor)
        {
            foreach (var node in nodes)
            {
                node.Accept(visitor);
            }
        }
    }
}
