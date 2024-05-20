using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLIbrary
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<TextDocument> _history;

        public TextEditor(string content)
        {
            _document = new TextDocument(content);
            _history = new Stack<TextDocument>();
        }

        public void Save()
        {
            var documentCopy = new TextDocument(_document.Content);
            _history.Push(documentCopy); 
        }


        public void Undo()
        {
            if (_history.Count > 0)
            {
                _document = _history.Pop();
            }
        }



        public void ModifyContent(string newContent)
        {
            _document.Content = newContent;
        }

        public void PrintContent()
        {
            Console.WriteLine("Document content:");
            Console.WriteLine(_document.Content);
        }
    }
}
