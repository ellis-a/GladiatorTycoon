using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Arena
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
