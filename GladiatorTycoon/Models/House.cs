using System;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        public City Location { get; set; }
        public int PeopleCapacity { get; set; }

    }
}
