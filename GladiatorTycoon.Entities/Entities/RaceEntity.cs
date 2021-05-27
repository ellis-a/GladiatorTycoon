using Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Races")]
    public class RaceEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveEntity> Passives { get; set; }
        public List<CombatClassEntity> AvalableClasses { get; set; }
        public Gender AvailableGenders { get; set; }
        public List<PersonNameEntity> AvailablePersonNames { get; set; }

        public string PositiveHabitats { get; set; }
        public string NegativeHabitats { get; set; }

        public List<AbilityEntity> Abilities { get; set; }
    }
}
