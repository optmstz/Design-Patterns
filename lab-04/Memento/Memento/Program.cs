using MementoClassLIbrary;

class Program
{
    static void Main(string[] args)
    {
        var textEditor = new TextEditor("Initial content");

        textEditor.PrintContent();
        textEditor.Save();
        textEditor.ModifyContent("Modified content");

        textEditor.PrintContent();
        textEditor.Undo();
        textEditor.PrintContent();
    }
}