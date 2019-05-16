using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("PersonBodyParts")]
    public class PersonBodyPartEntity
    {
        [Key]
        public int Id { get; set; }

        public RaceBodyPartEntity RaceBodyPart { get; set; }
        public List<InjuryEntity> Injuries { get; set; }
        public WeaponEntity EquippedWeapon { get; set; }
        public ArmourEntity EquippedArmour { get; set; }
    }
}
