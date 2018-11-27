using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Ability
    {
        [Key]
        public int Id { get; set; }

        public List<Effect> Effects { get; set; }
    }
}
