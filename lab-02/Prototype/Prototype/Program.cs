using PrototypeClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Virus originalVirus = new Virus
        {
            Weight = 0.1,
            Age = 1,
            Name = "Original Virus",
            Type = "COVID-19"
        };

        Virus child1 = (Virus)originalVirus.Clone();
        child1.Name = "Child Virus 1";
            
        Virus child2 = (Virus)originalVirus.Clone();
        child2.Name = "Child Virus 2";

        originalVirus.AddChild(child1);
        originalVirus.AddChild(child2);

        Virus grandChild1 = (Virus)child1.Clone();
        grandChild1.Name = "Grandchild Virus 1";

        Virus grandChild2 = (Virus)child1.Clone();
        grandChild2.Name = "Grandchild Virus 2";

        child1.AddChild(grandChild1);
        child1.AddChild(grandChild2);

        Virus grandChild3 = (Virus)child2.Clone();
        grandChild3.Name = "Grandchild Virus 3";

        Virus grandChild4 = (Virus)child2.Clone();
        grandChild4.Name = "Grandchild Virus 4";

        child2.AddChild(grandChild3);
        child2.AddChild(grandChild4);

        Console.WriteLine("Original Virus:");
        PrintVirusInfo(originalVirus, 0);
    }

    static void PrintVirusInfo(Virus virus, int level)
    {
        string indentation = new string('\t', level);
        Console.WriteLine($"{indentation}Name: {virus.Name}");
        Console.WriteLine($"{indentation}Weight: {virus.Weight}");
        Console.WriteLine($"{indentation}Age: {virus.Age}");
        Console.WriteLine($"{indentation}Type: {virus.Type}");
        Console.WriteLine($"{indentation}Children:");

        foreach (var child in virus.Children)
        {
            PrintVirusInfo(child, level + 1);
        }
    }
}

