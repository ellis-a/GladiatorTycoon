using GladiatorTycoon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Arena> Arenas { get; set; }
        public Habitat Habitat { get; set; }
    }
}
