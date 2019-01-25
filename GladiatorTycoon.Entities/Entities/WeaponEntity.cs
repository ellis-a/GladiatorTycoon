using GladiatorTycoon.Enums;

namespace GladiatorTycoon.Entities
{
    public class WeaponEntity : ItemEntity
    {
        public int Power { get; set; }
        public WeaponType WeaponType { get; set; }
        public bool IsTwoHander { get; set; }
    }
}
