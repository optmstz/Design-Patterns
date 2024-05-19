using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorClassLibrary
{
    public class BasicInventory : IInventory
    {
        public string Description() => "Basic Inventory";
    }

    public class ArmorDecorator : IInventory
    {
        private readonly IInventory _inventory;

        public ArmorDecorator(IInventory inventory)
        {
            _inventory = inventory;
        }

        public string Description() => $"{_inventory.Description()}, Armor";
    }

    public class WeaponDecorator : IInventory
    {
        private readonly IInventory _inventory;

        public WeaponDecorator(IInventory inventory)
        {
            _inventory = inventory;
        }

        public string Description() => $"{_inventory.Description()}, Weapon";
    }

}
