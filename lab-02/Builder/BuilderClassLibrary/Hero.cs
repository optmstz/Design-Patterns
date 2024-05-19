using System;

namespace BuilderClassLibrary
{
    public class Hero : ICharacter
    {
        public double Height { get; set; }
        public string Build { get; set; } = string.Empty;
        public string HairColor { get; set; } = string.Empty;
        public string EyeColor { get; set; } = string.Empty;
        public string Clothing { get; set; } = string.Empty;
        public List<string> Inventory { get; set; }
        public List<string> GoodDeeds { get; set; }

        public Hero()
        {
            Inventory = new List<string>();
            GoodDeeds = new List<string>();
        }

        public override string ToString()
        {
            string inventoryStr = string.Join(", ", Inventory);
            string goodDeedsStr = string.Join(", ", GoodDeeds);

            return $"Hero: Height - {Height}, Build - {Build}, Hair Color - {HairColor}, Eye Color - {EyeColor}, Clothing - {Clothing}, Inventory - [{inventoryStr}], Good Deeds - [{goodDeedsStr}]";
        }
    }
}
