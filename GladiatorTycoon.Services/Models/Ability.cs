using GladiatorTycoon.Enums;
using System.Collections.Generic;

namespace GladiatorTycoon.Services.Models
{
    public class Ability
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<Passive, int> Effects { get; set; }
        public bool DoesTargetAllies { get; set; }
        public bool DoesTargetEnemies { get; set; }
        public bool IsHeal { get; set; }
        public int HealValue { get; set; }
        public bool IsDamage { get; set; }
        public int DamageValue { get; set; }

        //public Ability Bounce { get; set; }
    }
}
