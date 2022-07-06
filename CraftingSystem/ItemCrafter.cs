using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftingSystem
{
    public class ItemCrafter
    {
        public Item CraftWeapon(List<Item> ingredients, int skill, WeaponType weaponType)
        {


            return new Item();
        }
    }

    enum WeaponType
    {
        Sword,
        Axe,
        Hammer
    }
}
