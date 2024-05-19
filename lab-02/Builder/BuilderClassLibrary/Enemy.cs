using System.Collections.Generic;

namespace BuilderClassLibrary
{
    public class Enemy : ICharacter
    {
        public double Height { get; set; }
        public string Build { get; set; } = string.Empty;
        public string HairColor { get; set; } = string.Empty;
        public string EyeColor { get; set; } = string.Empty;
        public string Clothing { get; set; } = string.Empty;
        public List<string> Inventory { get; set; }
        public List<string> EvilDeeds { get; set; }

        public Enemy()
        {
            Inventory = new List<string>();
            EvilDeeds = new List<string>();
        }

        public override string ToString()
        {
            string inventoryStr = string.Join(", ", Inventory);
            string evilDeedsStr = string.Join(", ", EvilDeeds);

            return $"Enemy: Height - {Height}, Build - {Build}, Hair Color - {HairColor}, Eye Color - {EyeColor}, Clothing - {Clothing}, Inventory - [{inventoryStr}], Evil Deeds - [{evilDeedsStr}]";
        }
    }
}
