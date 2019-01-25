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
    }
}
