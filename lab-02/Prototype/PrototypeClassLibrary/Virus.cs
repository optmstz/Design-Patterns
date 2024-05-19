namespace PrototypeClassLibrary
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }

        public List<Virus> Children { get; private set; } = new List<Virus>();

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = new Virus
            {
                Weight = this.Weight,
                Age = this.Age,
                Name = this.Name,
                Type = this.Type
            };

            foreach (var child in this.Children)
            {
                clone.AddChild((Virus)child.Clone());
            }

            return clone;
        }
    }
}
