using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ProxyClassLibrary
{
    public class SmartTextReaderLocker : IDisposable
    {
        private SmartTextReader? _textReader;
        private readonly string _filePath;
        private readonly string _pattern;

        public SmartTextReaderLocker(string filePath, string pattern)
        {
            _filePath = filePath;
            _pattern = pattern;
            if (IsAccessGranted())
            {
                _textReader = new SmartTextReader(filePath);
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        private bool IsAccessGranted()
        {
            return Regex.IsMatch(Path.GetFileName(_filePath), _pattern);
        }

        public void DisplayTextArray()
        {
            if (_textReader != null)
            {
                _textReader.DisplayTextArray();
            }
        }

        public void Dispose()
        {
            if (_textReader != null)
            {
                _textReader.Dispose();
            }
        }
    }
}
