using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class AbilityEntity
    {
        [Key]
        public int Id { get; set; }

        public List<EffectEntity> Effects { get; set; }
    }
}
