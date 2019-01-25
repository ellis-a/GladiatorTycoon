using GladiatorTycoon.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Afflictions")]
    public class AfflictionEntity
    {
        [Key]
        public int Id { get; set; }

        public Cure Cure { get; set; }
        public List<PassiveEntity> Effects { get; set; }
    }
}
