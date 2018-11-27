using GladiatorTycoon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Affliction
    {
        [Key]
        public int Id { get; set; }

        public Cure Cure { get; set; }
        public List<PassiveTrait> Effects { get; set; }
    }
}
