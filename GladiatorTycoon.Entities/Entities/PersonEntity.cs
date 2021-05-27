using Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
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
        public Gender Gender { get; set; }
        public CityEntity HomeCity { get; set; }

        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int BasePower { get; set; }
        public int BaseWits { get; set; }
        public int BaseSkill { get; set; }
        public int BaseCharisma { get; set; }
        public int BaseBravery { get; set; }
        public int Speed { get; set; }
        public int Popularity { get; set; }

        public List<ItemEntity> Equipment { get; set; }
    }
}
