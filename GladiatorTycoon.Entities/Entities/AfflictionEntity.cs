using GladiatorTycoon.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class AfflictionEntity
    {
        [Key]
        public int Id { get; set; }

        public Cure Cure { get; set; }
        public List<PassiveEntity> Effects { get; set; }
    }
}
