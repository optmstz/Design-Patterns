using System;
using System.IO;

public class SmartTextReader: IDisposable
{
    private string[][]? _textArray;

    public SmartTextReader(string filePath) => LoadText(filePath);

    private void LoadText(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        _textArray = new string[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            _textArray[i] = lines[i].Split(' ');
        }
    }

    public void DisplayTextArray()
    {
        if(_textArray != null)
        {
            foreach (var line in _textArray)
            {
                foreach (var word in line)
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }
        }
    }
    public void Dispose()
    {

    }
}
