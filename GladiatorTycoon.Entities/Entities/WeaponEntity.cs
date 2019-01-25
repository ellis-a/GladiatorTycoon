using GladiatorTycoon.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiatorTycoon.Entities
{
    [Table("Weapons")]
    public class WeaponEntity : ItemEntity
    {
        public int Offense { get; set; }
        public WeaponType WeaponType { get; set; }
        public bool IsTwoHander { get; set; }
    }
}
