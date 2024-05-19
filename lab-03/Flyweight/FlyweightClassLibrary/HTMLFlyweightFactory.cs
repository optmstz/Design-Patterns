using System;
using System.Collections.Generic;

namespace ComposerClassLibrary
{
    public class LightHTMLFactory
    {
        public static LightElementNode CreateHeading(string text, int level)
        {
            string tag = "h" + level;
            return new LightElementNode(tag, true, false) { new LightTextNode(text) };
        }

        public static LightElementNode CreateParagraph(string text)
        {
            return new LightElementNode("p", true, false) { new LightTextNode(text) };
        }

        public static LightElementNode CreateBlockquote(string text)
        {
            return new LightElementNode("blockquote", true, false) { new LightTextNode(text) };
        }
    }
}
