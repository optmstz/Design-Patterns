using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ComposerClassLibrary
{
    public class BookHTMLConverter
    {
        private readonly string[] _bookLines;
        private readonly List<LightNode> _htmlNodes;

        public BookHTMLConverter(string[] bookLines)
        {
            _bookLines = bookLines;
            _htmlNodes = new List<LightNode>();
        }

        public void ConvertToHTML()
        {
            bool firstLine = true;

            foreach (string line in _bookLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                LightElementNode node;
                if (firstLine)
                {
                    node = new LightElementNode("h1", true, false);
                    node.AddChild(new LightTextNode(line.Trim()));
                    firstLine = false;
                }
                else
                {
                    if (line.Length < 20)
                    {
                        node = new LightElementNode("h2", true, false);
                        node.AddChild(new LightTextNode(line.Trim()));
                    }
                    else if (Regex.IsMatch(line, @"^\s"))
                    {
                        node = new LightElementNode("blockquote", true, false);
                        node.AddChild(new LightTextNode(line.Trim()));
                    }
                    else
                    {
                        node = new LightElementNode("p", true, false);
                        node.AddChild(new LightTextNode(line.Trim()));
                    }
                }

                _htmlNodes.Add(node);
            }
        }

        public List<LightNode> GetHTMLNodes()
        {
            return _htmlNodes;
        }
    }
}
