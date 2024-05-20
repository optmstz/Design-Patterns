using ComposerClassLibrary;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class HtmlDocument : IEnumerable<LightNode>
    {
        private LightNode _rootNode;

        public HtmlDocument(LightNode rootNode)
        {
            _rootNode = rootNode;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            return new HtmlDepthFirstIterator(_rootNode);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
