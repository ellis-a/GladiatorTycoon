using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GladiatorTycoon.Enums;

namespace GladiatorTycoon.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveTrait> Racials { get; set; }

        public string PositiveHabitats { get; set; }
        public string NegativeHabitats { get; set; }
    }
}
