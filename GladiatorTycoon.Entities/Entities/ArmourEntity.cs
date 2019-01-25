using GladiatorTycoon.Enums;

namespace GladiatorTycoon.Entities
{
    public class ArmourEntity : ItemEntity
    {
        public int Toughness { get; set; }
        public ArmourSlot ArmourSlot { get; set; }
    }
}
