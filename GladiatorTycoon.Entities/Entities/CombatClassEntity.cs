using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("CombatClasses")]
    public class CombatClassEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveEntity> Passives { get; set; }
        public List<AbilityEntity> Abilities { get; set; }
    }
}
