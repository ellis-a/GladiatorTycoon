using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public City AffectedCity { get; set; }
        public House AffectedHouse { get; set; }
    }
}
