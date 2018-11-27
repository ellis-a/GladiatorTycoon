using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Deity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
