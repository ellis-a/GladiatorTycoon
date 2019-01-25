using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Gladiators")]
    public class GladiatorEntity : SlaveEntity
    {
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int Offense { get; set; }
        public int Defense { get; set; }

        public List<ItemEntity> Equipment { get; set; }
        public List<WeaponEntity> Weapons { get; set; }
        public List<ArmourEntity> Armour { get; set; }
    }
}
