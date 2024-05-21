using ComposerClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class HtmlBreadthFirstIterator : IEnumerator<LightNode>
    {
        private Queue<LightNode>? _queue;
        private LightNode? _currentNode;

        public HtmlBreadthFirstIterator(LightNode rootNode)
        {
            _queue = new Queue<LightNode>();
            _queue.Enqueue(rootNode);
        }

        public LightNode Current => _currentNode;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _queue?.Clear();
            _currentNode = null;
        }

        public bool MoveNext()
        {
            if (_queue?.Count == 0)
            {
                _currentNode = null;
                return false;
            }

            _currentNode = _queue?.Dequeue();

            if (_currentNode is LightElementNode elementNode)
            {
                List<LightNode> children = elementNode.GetChildren();
                foreach (var child in children)
                {
                    _queue?.Enqueue(child);
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
