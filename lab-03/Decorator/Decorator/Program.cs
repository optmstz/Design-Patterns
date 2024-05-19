using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using DecoratorClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        IHero warrior = new Warrior();
        IHero mage = new Mage();
        IHero paladin = new Paladin();

        IInventory warriorInventory = new ArmorDecorator(new WeaponDecorator(new BasicInventory()));
        IInventory mageInventory = new WeaponDecorator(new WeaponDecorator(new BasicInventory()));
        IInventory paladinInventory = new ArmorDecorator(new ArmorDecorator(new BasicInventory()));

        Console.WriteLine($"Warrior ({warrior.Class}): {warrior.Inventory} + {warriorInventory.Description()}");
        Console.WriteLine($"Mage ({mage.Class}): {mage.Inventory} + {mageInventory.Description()}");
        Console.WriteLine($"Paladin ({paladin.Class}): {paladin.Inventory} + {paladinInventory.Description()}");
    }
}