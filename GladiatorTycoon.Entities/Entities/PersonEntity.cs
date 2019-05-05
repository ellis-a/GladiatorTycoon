using GladiatorTycoon.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Persons")]
    public class PersonEntity
    {
        public PersonEntity() { }

        [Key]
        public int Id { get; set; }

        public bool IsAlive { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gold { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public RaceEntity Race { get; set; }
        public bool IsMale { get; set; }
        public CityEntity HomeCity { get; set; }

        public int Power { get; set; }
        public int Wits { get; set; }
        public int Skill { get; set; }
        public int Charisma { get; set; }
    }
}
