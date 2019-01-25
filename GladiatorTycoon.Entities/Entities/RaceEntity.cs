using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Entities
{
    public class RaceEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveEntity> Racials { get; set; }

        public string PositiveHabitats { get; set; }
        public string NegativeHabitats { get; set; }
    }
}
