using ComposerClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class HtmlDepthFirstIterator : IEnumerator<LightNode>
    {
        private Stack<LightNode>? _stack;
        private LightNode? _currentNode;

        public HtmlDepthFirstIterator(LightNode rootNode)
        {
            _stack = new Stack<LightNode>();
            _stack.Push(rootNode);
        }

        public LightNode Current => _currentNode;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _stack?.Clear();
            _currentNode = null;
        }

        public bool MoveNext()
        {
            if (_stack?.Count == 0)
            {
                _currentNode = null;
                return false;
            }

            _currentNode = _stack?.Pop();

            if (_currentNode is LightElementNode elementNode)
            {
                List<LightNode> children = elementNode.GetChildren();
                for (int i = children.Count - 1; i >= 0; i--)
                {
                    _stack?.Push(children[i]);
                }
            }

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
