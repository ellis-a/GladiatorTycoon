using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class ClassEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveEntity> Passives { get; set; }
    }
}
