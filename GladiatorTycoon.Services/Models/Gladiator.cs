using Enums;
using System.Collections.Generic;

namespace Services.Models
{
    public class Gladiator : Slave
    {
        public int Offense { get; set; }
        public int Defense { get; set; }

        public CombatClass CombatClass { get; set; }
        public List<Ability> Abilities { get; set; }

        public CombatFlags GetCombatFlags()
        {
            CombatFlags result = 0;
            foreach (var passive in CombatClass.Passives)
            {
                result |= passive.CombatFlags;
            }
            foreach (var passive in Race.Passives)
            {
                result |= passive.CombatFlags;
            }

            return result;
        }

        //public List<Affliction>

        //public List<Item> Equipment { get; set; }
        //public List<Weapon> Weapons { get; set; }
        //public List<Armour> Armour { get; set; }
    }
}
