using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Abilities")]
    public class AbilityEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<PassiveEntity, int> Effects { get; set; }
        public bool DoesTargetAllies { get; set; }
        public bool DoesTargetEnemies { get; set; }
        public bool IsHeal { get; set; }
        public int HealValue { get; set; }
        public bool IsDamage { get; set; }
        public int DamageValue { get; set; }
    }
}
