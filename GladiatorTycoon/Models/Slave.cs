using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Slave : Person
    {
        public int Loyalty { get; set; }
        public Dominus Owner { get; set; }
    }
}
