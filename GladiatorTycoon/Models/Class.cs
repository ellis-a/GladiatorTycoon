using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public List<PassiveTrait> ClassTraits { get; set; }

    }
}
