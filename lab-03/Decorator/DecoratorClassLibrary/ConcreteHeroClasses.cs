using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class Warrior : IHero
    {
        public string Class => "Warrior";
        public string Inventory => "Basic Sword";
    }

    public class Mage : IHero
    {
        public string Class => "Mage";
        public string Inventory => "Basic Staff";
    }

    public class Paladin : IHero
    {
        public string Class => "Paladin";
        public string Inventory => "Basic Shield";
    }
}
