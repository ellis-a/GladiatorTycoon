using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GladiatorTycoon.Models
{
    public class Party
    {
        [Key]
        public int Id { get; set; }

        public List<Person> Guests { get; set; }
        public int SuccessScore { get; set; }
    }
}
