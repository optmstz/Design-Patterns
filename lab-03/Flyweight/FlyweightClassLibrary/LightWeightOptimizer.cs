using ComposerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightClassLibrary
{
    public static class LightWeightOptimizer
    {
        public static void Optimize(List<LightNode> nodes)
        {
            Dictionary<string, LightTextNode> textNodeCache = new Dictionary<string, LightTextNode>();

            foreach (var node in nodes)
            {
                if (node is LightElementNode elementNode)
                {
                    Optimize(elementNode.GetChildren(), textNodeCache);
                }
            }
        }

        private static void Optimize(List<LightNode> nodes, Dictionary<string, LightTextNode> textNodeCache)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i] is LightElementNode elementNode)
                {
                    Optimize(elementNode.GetChildren(), textNodeCache);
                }
                else if (nodes[i] is LightTextNode textNode)
                {
                    if (textNodeCache.ContainsKey(textNode.OuterHTML()))
                    {
                        nodes[i] = textNodeCache[textNode.OuterHTML()];
                    }
                    else
                    {
                        textNodeCache.Add(textNode.OuterHTML(), textNode);
                    }
                }
            }
        }
    }
}
